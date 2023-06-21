using UnityEngine;

namespace EaseKit {
    public readonly struct Vector2Interpolator : IInterpolator<Vector2> {
        public static readonly Vector2Interpolator shared = new Vector2Interpolator();

        public Vector2 Evaluate(in Vector2 start, in Vector2 end, float percent)
            => Vector2.Lerp(start, end, percent);
    }
}