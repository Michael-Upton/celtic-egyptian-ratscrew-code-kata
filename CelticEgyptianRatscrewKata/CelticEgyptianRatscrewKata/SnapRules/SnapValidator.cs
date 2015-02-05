using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata.SnapRules
{
    public interface ISnapValidator
    {
        bool CanSnap(Cards cards);
    }

    public class SnapValidator : ISnapValidator
    {
        private readonly ICollection<ISnapValidator> _snappers;

        public SnapValidator()
        {
            _snappers = new ISnapValidator[]
                        {
                            new NSandwichSnapper(0),
                            new NSandwichSnapper(1),
                            new DarkQueenSnapper()
                        };
        }

        public bool CanSnap(Cards cards)
        {
            return _snappers.Any(snapper => snapper.CanSnap(cards));
        }
    }
}