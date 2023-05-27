#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct quaternionInterpolator : IInterpolator<quaternion> {
        public static readonly quaternionInterpolator shared = new quaternionInterpolator();

        public quaternion Evaluate(in quaternion start, in quaternion end, float percent)
            => math.slerp(start, end, percent);
    }
}
#endif