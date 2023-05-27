using UnityEngine;

namespace EaseKit {
    public readonly struct QuaternionInterpolator : IInterpolator<Quaternion> {
        public static readonly QuaternionInterpolator shared = new QuaternionInterpolator();

        public Quaternion Evaluate(in Quaternion start, in Quaternion end, float percent)
            => Quaternion.Slerp(start, end, percent);
    }
}