#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct double3Interpolator : IInterpolator<double3> {
        public double3 Evaluate(double3 start, double3 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif