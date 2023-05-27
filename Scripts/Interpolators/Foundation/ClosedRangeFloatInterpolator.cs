#if FOUNDATION_PACKAGE
using Foundation;
using UnityEngine;

namespace EaseKit {
    public readonly struct ClosedRangeFloatInterpolator : IInterpolator<ClosedRange<float>> {
        public static readonly ClosedRangeFloatInterpolator shared = new ClosedRangeFloatInterpolator();

        public ClosedRange<float> Evaluate(in ClosedRange<float> start, in ClosedRange<float> end, float percent) => new ClosedRange<float>(
            EasingUtility.lerp(start.lowerBound, end.lowerBound, percent),
            EasingUtility.lerp(start.upperBound, end.upperBound, percent)
        );
    }
}
#endif