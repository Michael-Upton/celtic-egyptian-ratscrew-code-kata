using System.Collections.Generic;
using CelticEgyptianRatscrewKata.SnapRules;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class SandwichSnapRuleTests
    {
        [Test]
        public void ShouldFailOnEmptyStack()
        {
            var rule = new SandwichSnapRule();
            var stack = Cards.Empty();
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldFailWithSandwichInStack()
        {
            var rule = new SandwichSnapRule();
            var stack = new Cards(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two),
                new Card(Suit.Clubs, Rank.Three),
            });
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldPassWithSandwichInStack()
        {
            var rule = new SandwichSnapRule();
            var stack = new Cards(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two),
                new Card(Suit.Spades, Rank.Ace),
            });
            Assert.That(rule.CanSnap(stack), Is.True);
        }
    }
}