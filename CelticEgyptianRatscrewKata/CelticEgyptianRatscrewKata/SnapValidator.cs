﻿using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public interface ISnapValidator
    {
        bool CanSnap(Stack cards);
    }

    public class SnapValidator : ISnapValidator
    {
        private readonly ICollection<ISnapValidator> _snappers;

        public SnapValidator()
        {
            _snappers = new[] {new NSandwichSnapper(0), new NSandwichSnapper(1)};
        }

        public bool CanSnap(Stack cards)
        {
            return _snappers.Any(snapper => snapper.CanSnap(cards));
        }
    }
}