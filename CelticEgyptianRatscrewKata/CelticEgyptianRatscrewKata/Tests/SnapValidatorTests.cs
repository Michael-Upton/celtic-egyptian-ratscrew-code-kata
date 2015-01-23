
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    [TestFixture]
    public class SnapValidatorTests
    {
        [TestCaseSource("StacksWithSnaps")]
        [TestCaseSource("StacksWithoutSnaps")]
        public bool SnapValidator(Stack cards)
        {
            return new SnapValidator().CanSnap(cards);
        }

        private IEnumerable<TestCaseData> StacksWithSnaps
        {
            get
            {
                yield return ShouldSnap("Standard Snap",
                                        Rank.Eight.Of(Suit.Clubs),
                                        Rank.Eight.Of(Suit.Spades));

            }
        }

        private IEnumerable<TestCaseData> StacksWithoutSnaps
        {
            get
            {
                yield return ShouldNotSnap("No cards");
                yield return ShouldNotSnap("Single Card",
                                           Rank.Seven.Of(Suit.Clubs));
            }
        }

        private static TestCaseData ShouldSnap(string testName, params Card[] cards)
        {
            return TestStack(testName, cards).Returns(true);
        }

        private static TestCaseData ShouldNotSnap(string testName, params Card[] cards)
        {
            return TestStack(testName, cards).Returns(false);
        }

        private static TestCaseData TestStack(string testName, params Card[] cards)
        {
            return new TestCaseData(new Stack(cards)).SetName(testName);
        }
    }
}
