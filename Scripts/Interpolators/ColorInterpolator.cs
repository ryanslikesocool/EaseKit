using UnityEngine;

namespace EaseKit {
    public readonly struct ColorInterpolator : IInterpolator<Color> {
        public Color Evaluate(Color start, Color end, float percent)
            => Color.Lerp(start, end, percent);
    }
}