using UnityEngine;

namespace EaseKit {
    public struct Vector3Interpolator : IInterpolator<Vector3> {
        public Vector3 Evaluate(Vector3 start, Vector3 end, float percent)
            => Vector3.Lerp(start, end, percent);
    }
}