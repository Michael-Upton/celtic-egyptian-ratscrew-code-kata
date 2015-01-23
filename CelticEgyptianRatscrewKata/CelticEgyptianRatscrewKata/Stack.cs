using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Stack : IEnumerable<Card>
    {
        private readonly List<Card> _cards;

        public Stack(params Card[] cards) : this((IEnumerable<Card>)cards) { }

        public Stack(IEnumerable<Card> cards)
        {
            _cards = cards.ToList();
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return _cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Maybe<Card> TopCard
        {
            get { return _cards.LastOrDefault() ?? Maybe<Card>.Nothing;}
        }

        public override string ToString()
        {
            return string.Format("Stack [{0}]",
                                 string.Join(", ", this.Select(card => string.Format("{0} of {1}", card.Rank, card.Suit))));
        }
    }
}