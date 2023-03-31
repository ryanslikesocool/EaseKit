#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct double4Interpolator : IInterpolator<double4> {
        public double4 Evaluate(double4 start, double4 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif