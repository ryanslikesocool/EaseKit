#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public struct quaternionInterpolator : IInterpolator<quaternion> {
        public quaternion Evaluate(quaternion start, quaternion end, float percent)
            => math.slerp(start, end, percent);
    }
}
#endif