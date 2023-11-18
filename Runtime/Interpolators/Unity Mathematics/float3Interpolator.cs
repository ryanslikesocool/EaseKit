#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct float3Interpolator : IInterpolator<float3> {
        public static readonly float3Interpolator shared = new float3Interpolator();

        public float3 Evaluate(in float3 start, in float3 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif