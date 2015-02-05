using Moq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class ShufflerTests
    {
        [Test]
        public void ShufflingEmptyDeckReturnsEmptyDeck()
        {
            var deck = Cards.Empty();
            var shuffler = new Shuffler();

            var shuffledDeck = shuffler.Shuffle(deck);

            var expectedDeck = Cards.Empty();
            Assert.That(shuffledDeck, Is.EqualTo(expectedDeck));
        }

        [Test]
        public void ShufflingDeckWithOneCardReturnsDeckWithOneCard()
        {
            var aceOfClubs = Rank.Ace.Of(Suit.Clubs);
            var deck = new Cards(aceOfClubs);
            var shuffler = new Shuffler();

            var shuffledDeck = shuffler.Shuffle(deck);

            var expectedDeck = new Cards(aceOfClubs);
            Assert.That(shuffledDeck, Is.EqualTo(expectedDeck));
        }

        [Test]
        public void ShufflingAFullDeckReturnsTheSameCards()
        {
            var shuffler = new Shuffler();

            var shuffledDeck = shuffler.Shuffle(Cards.Deck());

            Assert.That(shuffledDeck, Is.EquivalentTo(Cards.Deck()));
        }
    }
}