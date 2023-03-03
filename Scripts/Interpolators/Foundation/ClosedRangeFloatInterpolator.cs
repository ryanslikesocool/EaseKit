#if FOUNDATION_PACKAGE
using Foundation;
using UnityEngine;

namespace EaseKit {
    public struct ClosedRangeFloatInterpolator : IInterpolator<ClosedRange<float>> {
        public ClosedRange<float> Evaluate(ClosedRange<float> start, ClosedRange<float> end, float percent) => new ClosedRange<float>(
            EasingUtility.lerp(start.lowerBound, end.lowerBound, percent),
            EasingUtility.lerp(start.upperBound, end.upperBound, percent)
        );
    }
}
#endif