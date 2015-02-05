using System.Collections.Generic;

namespace CelticEgyptianRatscrewKata
{
    public interface IShuffler
    {
        Cards Shuffle(IEnumerable<Card> deck);
    }
}