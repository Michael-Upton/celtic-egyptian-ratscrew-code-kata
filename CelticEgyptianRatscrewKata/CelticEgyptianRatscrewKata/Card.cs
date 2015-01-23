namespace CelticEgyptianRatscrewKata
{
    public class Card
    {
        public Suit Suit { get; private set; }
        public Rank Rank { get; private set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return string.Format("Card {0} of {1}", Rank, Suit);
        }

        #region EqualityMembers
        protected bool Equals(Card other)
        {
            return Suit == other.Suit && Rank == other.Rank;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Card) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) Suit*397) ^ (int) Rank;
            }
        }
#endregion
    }
}