#if CLOCKKIT_2
using System;
using EaseKit;

namespace ClockKit {
    public struct EasingAnimation<Value> : IFixedDurationAnimation<Value> {
        public float Duration { get; }
        public readonly EasingUtility.Function easingFunction;
        public readonly Value start;
        public readonly Value end;
        public readonly IInterpolator<Value> interpolator;

        public EasingAnimation(Easing easing, float duration, Value start, Value end) : this(EasingUtility.CreateInterpolator<Value>(), easing.GetFunction(), duration, start, end) { }

        public EasingAnimation(IInterpolator<Value> interpolator, Easing easing, float duration, Value start, Value end) : this(interpolator, easing.GetFunction(), duration, start, end) { }

        public EasingAnimation(EasingUtility.Function easingFunction, float duration, Value start, Value end) : this(EasingUtility.CreateInterpolator<Value>(), easingFunction, duration, start, end) { }

        public EasingAnimation(IInterpolator<Value> interpolator, EasingUtility.Function easingFunction, float duration, Value start, Value end) {
            this.Duration = duration;
            this.easingFunction = easingFunction;
            this.start = start;
            this.end = end;
            this.interpolator = interpolator;
        }

        public Value Evaluate(float percent)
            => EasingUtility.Ease(interpolator, easingFunction, start, end, percent);
    }
}
#endif