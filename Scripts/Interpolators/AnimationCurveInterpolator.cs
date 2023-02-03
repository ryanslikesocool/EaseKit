using UnityEngine;

namespace EaseKit {
    public struct AnimationCurveInterpolator<Value> : IInterpolator<Value> {
        public readonly AnimationCurve animationCurve;
        public readonly IInterpolator<Value> subinterpolator;

        public AnimationCurveInterpolator(AnimationCurve animationCurve, IInterpolator<Value> subinterpolator) {
            this.animationCurve = animationCurve;
            this.subinterpolator = subinterpolator;
        }

        public Value Evaluate(Value start, Value end, float percent) {
            float animationCurveValue = animationCurve.Evaluate(percent);
            return subinterpolator.Evaluate(start, end, animationCurveValue);
        }
    }
}