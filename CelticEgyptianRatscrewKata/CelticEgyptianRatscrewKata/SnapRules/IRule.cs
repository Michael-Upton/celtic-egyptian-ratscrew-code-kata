namespace CelticEgyptianRatscrewKata.SnapRules
{
    public interface IRule
    {
        bool CanSnap(Cards stack);
    }
}