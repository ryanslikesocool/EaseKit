using UnityEngine;

namespace EaseKit {
    public readonly struct Vector3Interpolator : IInterpolator<Vector3> {
        public static readonly Vector3Interpolator shared = new Vector3Interpolator();

        public Vector3 Evaluate(in Vector3 start, in Vector3 end, float percent)
            => Vector3.Lerp(start, end, percent);
    }
}