using System;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class NSandwichSnapper : ISnapValidator
    {
        private readonly int _gap;

        public NSandwichSnapper(int gap)
        {
            if (gap < 0) throw new ArgumentOutOfRangeException("gap", gap, "Gap must not be negative");
            _gap = gap;
        }

        public bool CanSnap(Stack cards)
        {
            return cards.Zip(cards.Skip(_gap + 1), HaveSameRank).Any(b => b);
        }

        private bool HaveSameRank(Card firstCard, Card secondCard)
        {
            return firstCard.Rank == secondCard.Rank;
        }
    }
}