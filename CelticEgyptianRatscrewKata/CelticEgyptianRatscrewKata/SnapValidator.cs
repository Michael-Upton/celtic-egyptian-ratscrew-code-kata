namespace CelticEgyptianRatscrewKata
{
    public interface ISnapValidator
    {
        bool CanSnap(Stack cards);
    }

    public class SnapValidator : ISnapValidator
    {
        public bool CanSnap(Stack cards)
        {
            throw new System.NotImplementedException();
        }
    }
}