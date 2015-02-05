using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    [TestFixture]
    public class CardsTests
    {
        [Test]
        public void DeckReturns52Cards()
        {
            Assert.That(Cards.Deck().Count(), Is.EqualTo(52));
        }

        [Test]
        public void AllCardsInDeckAreUnique()
        {
            Assert.That(Cards.Deck(), Is.Unique);
        }
    }
}
