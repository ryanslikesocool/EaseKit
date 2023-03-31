using UnityEngine;

namespace EaseKit {
    public readonly struct Vector4Interpolator : IInterpolator<Vector4> {
        public Vector4 Evaluate(Vector4 start, Vector4 end, float percent)
            => Vector4.Lerp(start, end, percent);
    }
}