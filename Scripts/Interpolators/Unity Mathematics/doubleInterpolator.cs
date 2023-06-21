#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
    public readonly struct doubleInterpolator : IInterpolator<double> {
        public static readonly doubleInterpolator shared = new doubleInterpolator();

        public double Evaluate(in double start, in double end, float percent)
            => math.lerp(start, end, percent);
    }
}
#endif
