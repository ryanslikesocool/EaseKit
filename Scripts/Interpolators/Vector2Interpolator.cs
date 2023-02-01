using UnityEngine;

namespace EaseKit {
    public struct Vector2Interpolator : IInterpolator<Vector2> {
        public Vector2 Evaluate(Vector2 start, Vector2 end, float percent)
            => Vector2.Lerp(start, end, percent);
    }
}