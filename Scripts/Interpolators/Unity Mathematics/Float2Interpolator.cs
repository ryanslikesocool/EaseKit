#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct float2Interpolator : IInterpolator<float2> {
        public static readonly float2Interpolator shared = new float2Interpolator();

        public float2 Evaluate(in float2 start, in float2 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif