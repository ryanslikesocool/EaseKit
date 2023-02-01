#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public struct quaternionSlerpInterpolator : IInterpolator<quaternion> {
        public quaternion Evaluate(quaternion start, quaternion end, float percent)
            => math.slerp(start, end, percent);
    }
}
#endif