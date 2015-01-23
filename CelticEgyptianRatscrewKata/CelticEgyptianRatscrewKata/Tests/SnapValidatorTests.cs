using System.Collections.Generic;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    [TestFixture]
    public class SnapValidatorTests
    {
        [TestCaseSource("StandardSnaps")]
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

        private IEnumerable<TestCaseData> StacksWithoutSnaps
        {
            get
            {
                yield return ShouldNotSnap();

                yield return ShouldNotSnap(Rank.Seven.Of(Suit.Clubs));

                yield return ShouldNotSnap(Rank.Seven.Of(Suit.Clubs),
                                           Rank.Eight.Of(Suit.Clubs),
                                           Rank.Ace.Of(Suit.Spades),
                                           Rank.Seven.Of(Suit.Hearts));
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
