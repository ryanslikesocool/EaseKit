using UnityEngine;

namespace EaseKit {
    public readonly struct Vector4Interpolator : IInterpolator<Vector4> {
        public static readonly Vector3Interpolator shared = new Vector3Interpolator();

        public Vector4 Evaluate(in Vector4 start, in Vector4 end, float percent)
            => Vector4.Lerp(start, end, percent);
    }
}