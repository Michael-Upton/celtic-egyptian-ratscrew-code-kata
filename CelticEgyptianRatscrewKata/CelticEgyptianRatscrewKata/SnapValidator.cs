using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public interface ISnapValidator
    {
        bool CanSnap(Stack cards);
    }

    public class SnapValidator : ISnapValidator
    {
        public bool CanSnap(Stack cards)
        {
            return cards.Zip(cards.Skip(1), HaveSameRank).Any(b => b);
        }

        private bool HaveSameRank(Card firstCard, Card secondCard)
        {
            return firstCard.Rank == secondCard.Rank;
        }
    }
}