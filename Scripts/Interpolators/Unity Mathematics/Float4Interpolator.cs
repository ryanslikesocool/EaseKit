#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct float4Interpolator : IInterpolator<float4> {
        public float4 Evaluate(float4 start, float4 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif