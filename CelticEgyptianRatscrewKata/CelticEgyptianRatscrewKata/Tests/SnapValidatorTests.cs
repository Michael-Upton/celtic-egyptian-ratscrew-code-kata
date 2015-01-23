using System.Collections.Generic;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    [TestFixture]
    public class SnapValidatorTests
    {
        [TestCaseSource("StandardSnaps")]
        [TestCaseSource("SandwichSnaps")]
        [TestCaseSource("DarkQueenSnaps")]
        [TestCaseSource("StacksWithoutSnaps")]
        public bool SnapValidator(Stack cards)
        {
            return new SnapValidator().CanSnap(cards);
        }

        private IEnumerable<TestCaseData> StandardSnaps
        {
            get
            {
                yield return ShouldSnap(Rank.Eight.Of(Suit.Clubs),
                                        Rank.Eight.Of(Suit.Spades));

                yield return ShouldSnap(Rank.Eight.Of(Suit.Diamonds),
                                        Rank.Five.Of(Suit.Spades),
                                        Rank.Five.Of(Suit.Hearts),
                                        Rank.Four.Of(Suit.Diamonds));

                yield return ShouldSnap(Rank.Ace.Of(Suit.Spades),
                                        Rank.Ace.Of(Suit.Hearts),
                                        Rank.Queen.Of(Suit.Diamonds));

                yield return ShouldSnap(Rank.Queen.Of(Suit.Diamonds),
                                        Rank.Ace.Of(Suit.Spades),
                                        Rank.Ace.Of(Suit.Hearts));
            }
        }
        private IEnumerable<TestCaseData> DarkQueenSnaps
        {
            get
            {
                yield return ShouldSnap(Rank.Queen.Of(Suit.Spades));

                yield return ShouldSnap(Rank.Seven.Of(Suit.Clubs), Rank.Queen.Of(Suit.Spades));

                yield return ShouldSnap(Rank.Seven.Of(Suit.Clubs),
                                           Rank.Eight.Of(Suit.Clubs),
                                           Rank.Ace.Of(Suit.Spades),
                                           Rank.Seven.Of(Suit.Hearts),
                                           Rank.Queen.Of(Suit.Spades));
            }
        }
        
        private IEnumerable<TestCaseData> SandwichSnaps
        {
            get
            {
                yield return ShouldSnap(Rank.Eight.Of(Suit.Clubs),
                                        Rank.Five.Of(Suit.Clubs),
                                        Rank.Eight.Of(Suit.Spades));

                yield return ShouldSnap(Rank.Eight.Of(Suit.Clubs),
                                        Rank.Eight.Of(Suit.Hearts),
                                        Rank.Eight.Of(Suit.Spades));


                yield return ShouldSnap(Rank.Eight.Of(Suit.Diamonds),
                                        Rank.Five.Of(Suit.Spades),
                                        Rank.Four.Of(Suit.Clubs),
                                        Rank.Five.Of(Suit.Hearts),
                                        Rank.Four.Of(Suit.Diamonds));

                yield return ShouldSnap(Rank.Ace.Of(Suit.Spades),
                                        Rank.Four.Of(Suit.Clubs),
                                        Rank.Ace.Of(Suit.Hearts),
                                        Rank.Queen.Of(Suit.Diamonds));

                yield return ShouldSnap(Rank.Queen.Of(Suit.Diamonds),
                                        Rank.Ace.Of(Suit.Spades),
                                        Rank.Four.Of(Suit.Clubs),
                                        Rank.Ace.Of(Suit.Hearts));
            }
        }

        private IEnumerable<TestCaseData> StacksWithoutSnaps
        {
            get
            {
                yield return ShouldNotSnap();

                yield return ShouldNotSnap(Rank.Seven.Of(Suit.Clubs));

                yield return ShouldNotSnap(Rank.Queen.Of(Suit.Spades),
                                           Rank.Seven.Of(Suit.Clubs));

                yield return ShouldNotSnap(Rank.Seven.Of(Suit.Clubs),
                                           Rank.Eight.Of(Suit.Clubs),
                                           Rank.Ace.Of(Suit.Spades),
                                           Rank.Seven.Of(Suit.Hearts));

                yield return ShouldNotSnap(Rank.Seven.Of(Suit.Clubs),
                                           Rank.Eight.Of(Suit.Clubs),
                                           Rank.Ace.Of(Suit.Spades),
                                           Rank.Queen.Of(Suit.Spades),
                                           Rank.Seven.Of(Suit.Hearts));

                yield return ShouldNotSnap(Rank.Seven.Of(Suit.Clubs), Rank.Queen.Of(Suit.Clubs));
            }
        }

        private static TestCaseData ShouldSnap(params Card[] cards)
        {
            return TestStack(cards, " should snap").Returns(true);
        }

        private static TestCaseData ShouldNotSnap(params Card[] cards)
        {
            return TestStack(cards, " should not snap").Returns(false);
        }

        private static TestCaseData TestStack(IEnumerable<Card> cards, string testName)
        {
            var stack = new Stack(cards);
            return new TestCaseData(stack).SetName(stack + testName);
        }
    }
}
