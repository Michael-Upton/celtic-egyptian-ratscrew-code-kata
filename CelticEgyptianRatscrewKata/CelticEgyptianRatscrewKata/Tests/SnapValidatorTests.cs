
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
                return new[] {
                    TestStack("Standard Snap",
                            Rank.Eight.Of(Suit.Clubs),
                            Rank.Eight.Of(Suit.Spades)
                       )}.Select(tc => tc.Returns(true));
            }
        }

        private IEnumerable<TestCaseData> StacksWithoutSnaps
        {
            get
            {
                return new[] {
                    TestStack("Single Card",
                            Rank.Seven.Of(Suit.Clubs)
                       )}.Select(tc => tc.Returns(false));
            }
        }

        private static TestCaseData TestStack(string testName, params Card[] cards)
        {
            return new TestCaseData(new Stack(cards)).SetName(testName);
        }
    }
}
