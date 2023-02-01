using UnityEngine;

namespace EaseKit {
    public struct QuaternionSlerpInterpolator : IInterpolator<Quaternion> {
        public Quaternion Evaluate(Quaternion start, Quaternion end, float percent)
            => Quaternion.Slerp(start, end, percent);
    }
}