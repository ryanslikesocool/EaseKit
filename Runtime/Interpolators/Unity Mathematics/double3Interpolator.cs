#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct double3Interpolator : IInterpolator<double3> {
        public static readonly double3Interpolator shared = new double3Interpolator();

        public double3 Evaluate(in double3 start, in double3 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif