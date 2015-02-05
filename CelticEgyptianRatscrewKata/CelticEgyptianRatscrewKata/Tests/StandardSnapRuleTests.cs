using System.Collections.Generic;
using CelticEgyptianRatscrewKata.SnapRules;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class StandardSnapRuleTests
    {
        [Test]
        public void ShouldFailOnEmptyStack()
        {
            var stack = Cards.Empty();

            var rule = new StandardSnapRule();
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldFailIfNoPairFound()
        {
            var stack = new Cards(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two),
            });

            var rule = new StandardSnapRule();
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldPassIfPairInStack()
        {
            var stack = new Cards(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two),
                new Card(Suit.Diamonds, Rank.Two),
                new Card(Suit.Clubs, Rank.Three),
            });

            var rule = new StandardSnapRule();
            Assert.That(rule.CanSnap(stack), Is.True);
        }
    }
}