#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public struct double2Interpolator : IInterpolator<double2> {
        public double2 Evaluate(double2 start, double2 end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif