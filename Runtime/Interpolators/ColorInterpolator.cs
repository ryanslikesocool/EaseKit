using UnityEngine;

namespace EaseKit {
    public readonly struct ColorInterpolator : IInterpolator<Color> {
        public static readonly ColorInterpolator shared = new ColorInterpolator();

        public Color Evaluate(in Color start, in Color end, float percent)
            => Color.Lerp(start, end, percent);
    }
}