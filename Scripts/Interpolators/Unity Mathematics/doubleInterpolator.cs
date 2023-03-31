#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct doubleInterpolator : IInterpolator<double> {
        public double Evaluate(double start, double end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif
