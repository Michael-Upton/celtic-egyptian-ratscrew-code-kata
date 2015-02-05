using System.Linq;

namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class DarkQueenSnapRule : IRule
    {
        private static readonly Card s_QueenOfSpades = new Card(Suit.Spades, Rank.Queen);

        public bool CanSnap(Cards stack)
        {
            var topCard = stack.FirstOrDefault();
            return s_QueenOfSpades.Equals(topCard);
        }
    }
}