using System;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Shuffler : IShuffler
    {
        public Cards Shuffle(IEnumerable<Card> deck)
        {
            var random = new Random();
            return new Cards(deck.OrderBy(c => random.Next()));
        }
    }
}