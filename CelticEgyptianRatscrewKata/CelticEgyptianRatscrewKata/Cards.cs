using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Cards : IEnumerable<Card>
    {
        private readonly List<Card> m_Cards;

        public Cards(params Card[] cards) : this((IEnumerable<Card>)cards) { }

        public Cards(IEnumerable<Card> cards)
        {
            m_Cards = new List<Card>(cards);
        }

        public void AddToTop(Card card)
        {
            m_Cards.Add(card);
        }

        public Card Pop()
        {
            var top = CardAt(IndexOfTop);
            RemoveCardAt(IndexOfTop);
            return top;
        }

        private int IndexOfTop
        {
            get { return m_Cards.Count - 1; }
        }

        public Card CardAt(int i)
        {
            return m_Cards.ElementAt(i);
        }

        public void RemoveCardAt(int i)
        {
            m_Cards.RemoveAt(i);
        }

        public bool HasCards
        {
            get { return m_Cards.Count > 0; } 
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return m_Cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Cards Empty()
        {
            return new Cards();
        }

        public Maybe<Card> TopCard
        {
            get { return HasCards ? CardAt(IndexOfTop) : Maybe<Card>.Nothing; }
        }

        public override string ToString()
        {
            return string.Format("[{0}]",
                                 string.Join(", ", this.Select(card => string.Format("{0} of {1}", card.Rank, card.Suit))));
        }
    }
}