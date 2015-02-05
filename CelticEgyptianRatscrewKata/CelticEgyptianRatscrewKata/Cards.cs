using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Cards : IEnumerable<Card>
    {
        private readonly List<Card> m_Cards;

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
            var first = m_Cards.First();
            m_Cards.RemoveAt(0);
            return first;
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
            return With();
        }

        public static Cards With(Cards cards)
        {
            return With(cards.ToArray());
        }

        public static Cards With(params Card[] cards)
        {
            return new Cards(cards);
        }

        public override string ToString()
        {
            var output = "";

            foreach (var card in m_Cards)
            {
                if (!output.Equals("")) output += ", ";
                output += card;
            }

            return output;
        }
    }
}