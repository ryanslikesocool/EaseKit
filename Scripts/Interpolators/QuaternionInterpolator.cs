using UnityEngine;

namespace EaseKit {
    public readonly struct QuaternionInterpolator : IInterpolator<Quaternion> {
        public Quaternion Evaluate(Quaternion start, Quaternion end, float percent)
            => Quaternion.Slerp(start, end, percent);
    }
}