#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public struct float2Interpolator : IInterpolator<float2> {
        public float2 Evaluate(float2 start, float2 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif