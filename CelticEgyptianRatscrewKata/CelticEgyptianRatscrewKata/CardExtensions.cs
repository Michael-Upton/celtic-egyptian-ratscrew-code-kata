namespace CelticEgyptianRatscrewKata
{
    public static class CardExtensions
    {
        public static Card Of(this Rank rank, Suit suit)
        {
            return new Card(suit, rank);
        }
    }
}