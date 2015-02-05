namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class DarkQueenSnapper : ISnapValidator
    {
        public bool CanSnap(Cards cards)
        {
            return cards.TopCard.Equals(Rank.Queen.Of(Suit.Spades));
        }
    }
}