#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public struct float3Interpolator : IInterpolator<float3> {
        public float3 Evaluate(float3 start, float3 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif