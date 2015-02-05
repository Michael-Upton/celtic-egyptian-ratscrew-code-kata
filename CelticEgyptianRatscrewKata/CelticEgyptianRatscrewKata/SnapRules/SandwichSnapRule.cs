namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class SandwichSnapRule : IRule
    {
        public bool CanSnap(Cards stack)
        {
            Rank? oneBeforeCurrent = null;
            Rank? twoBeforeCurrent = null;
            foreach (var card in stack)
            {
                if (card.Rank == twoBeforeCurrent) return true;
                twoBeforeCurrent = oneBeforeCurrent;
                oneBeforeCurrent = card.Rank;
            }
            return false;
        }
    }
}