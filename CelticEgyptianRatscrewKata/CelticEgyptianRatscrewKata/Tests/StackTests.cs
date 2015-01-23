using System.Collections.Generic;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class StackTests
    {
        [Test]
        public void ShouldReadTopCardOnStack()
        {
            var expectedCard = Rank.Ace.Of(Suit.Spades);

            var stack = new Stack(Rank.Nine.Of(Suit.Hearts),
                                  expectedCard);

            Assert.That(stack.TopCard, Is.EqualTo((Maybe<Card>)expectedCard));
        }

        [Test]
        public void TopCardOfEmptyStackShouldBeNothing()
        {
            var stack = new Stack();
            Assert.That(stack.TopCard, Is.EqualTo(Maybe<Card>.Nothing));
        }

        [Test]
        public void ShouldReadAllCards()
        {
            var expectedCardsInStack = new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two),
                new Card(Suit.Clubs, Rank.Three),
            };
            var stack = new Stack(expectedCardsInStack);

            CollectionAssert.AreEqual(stack, expectedCardsInStack);
            
        }
    }
}