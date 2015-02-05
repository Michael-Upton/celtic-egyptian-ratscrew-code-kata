using System.Collections.Generic;
using CelticEgyptianRatscrewKata.SnapRules;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class DarkQueenSnapRuleTests
    {
        [Test]
        public void ShouldFailOnEmptyStack()
        {
            var rule = new DarkQueenSnapRule();
            var stack = Cards.Empty();
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldFailWithQueenNotAtTop()
        {
            var rule = new DarkQueenSnapRule();
            var stack = new Cards(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Spades, Rank.Queen)
            });
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldFailWithNoQueenOfSpades()
        {
            var rule = new DarkQueenSnapRule();
            var stack = new Cards(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
            });
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldPassWithQueenAtTop()
        {
            var rule = new DarkQueenSnapRule();
            var stack = new Cards(new List<Card>
            {
                new Card(Suit.Spades, Rank.Queen),
                new Card(Suit.Clubs, Rank.Ace)
            });
            Assert.That(rule.CanSnap(stack), Is.True);
        }
    }
}