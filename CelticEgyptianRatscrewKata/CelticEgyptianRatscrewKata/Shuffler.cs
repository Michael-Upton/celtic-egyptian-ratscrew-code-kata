using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Shuffler
    {
        private readonly IRandomNumberGenerator m_RandomNumberGenerator;

        public Shuffler() : this(new RandomNumberGenerator())
        {
        }

        public Shuffler(IRandomNumberGenerator randomNumberGenerator)
        {
            m_RandomNumberGenerator = randomNumberGenerator;
        }

        public Cards Shuffle(Cards deck)
        {
            var shuffledDeck = Cards.Empty();

            var unshuffledDeck = new Cards(deck);
            while (unshuffledDeck.HasCards)
            {
                var randomInt = m_RandomNumberGenerator.Get(0, unshuffledDeck.Count());
                var nextCard = unshuffledDeck.CardAt(randomInt);
                unshuffledDeck.RemoveCardAt(randomInt);
                shuffledDeck.AddToTop(nextCard);
            }

            return shuffledDeck;
        }
    }
}