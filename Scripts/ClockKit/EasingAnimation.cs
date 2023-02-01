#if CLOCKKIT_2
using System;
using EaseKit;

namespace ClockKit {
    public struct EasingAnimation<Value> : IFixedDurationAnimation<Value> {
        public float Duration { get; }
        public readonly Functions.Function easingFunction;
        public readonly Value start;
        public readonly Value end;
        public readonly IInterpolator<Value> interpolator;

        public EasingAnimation(Easing easing, float duration, Value start, Value end) : this(start.CreateInterpolator(), easing.GetFunction(), duration, start, end) { }

        public EasingAnimation(IInterpolator<Value> interpolator, Easing easing, float duration, Value start, Value end) : this(interpolator, easing.GetFunction(), duration, start, end) { }

        public EasingAnimation(Functions.Function easingFunction, float duration, Value start, Value end) : this(start.CreateInterpolator(), easingFunction, duration, start, end) { }

        public EasingAnimation(IInterpolator<Value> interpolator, Functions.Function easingFunction, float duration, Value start, Value end) {
            this.Duration = duration;
            this.easingFunction = easingFunction;
            this.start = start;
            this.end = end;
            this.interpolator = interpolator;
        }

        public Value Evaluate(float percent)
            => Extensions.Ease(interpolator, easingFunction, start, end, percent);
    }
}
#endif