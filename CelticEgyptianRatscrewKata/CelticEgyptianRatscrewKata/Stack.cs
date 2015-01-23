using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Stack : IEnumerable<Card>
    {
        private readonly List<Card> m_Cards;

        public Stack() : this(Enumerable.Empty<Card>()) { } 
        public Stack(IEnumerable<Card> cards)
        {
            m_Cards = new List<Card>(cards);
        }

        public void Add(Card c)
        {
            m_Cards.Add(c);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return m_Cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}