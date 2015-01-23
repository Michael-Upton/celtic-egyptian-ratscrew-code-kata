namespace CelticEgyptianRatscrewKata
{
    public class DarkQueenSnapper : ISnapValidator
    {
        public bool CanSnap(Stack cards)
        {
            return cards.TopCard.Equals(Rank.Queen.Of(Suit.Spades));
        }
    }
}