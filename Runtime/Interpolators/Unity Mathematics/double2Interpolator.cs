#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct double2Interpolator : IInterpolator<double2> {
        public static readonly double2Interpolator shared = new double2Interpolator();

        public double2 Evaluate(in double2 start, in double2 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif