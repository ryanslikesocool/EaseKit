#if CLOCKKIT_2
using UnityEngine;
using ClockKit;
using Foundation;

namespace EaseKit {
    public static class ClockExtensions {
        public static UUID Ease<Value>(this Clock clock, Queue queue, in UUID key, IInterpolator<Value> interpolator, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null) {
            EasingAnimation<Value> animation = new EasingAnimation<Value>(
                interpolator: interpolator,
                easing: easing,
                duration: duration,
                start: start,
                end: end
            );
            ITimer timer = new AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>(
                startTime: Time.time,
                animation: animation,
                onUpdate: onUpdate,
                onComplete: onComplete
            );
            return Clock.StartTimer(queue, key, timer);
        }

        public static UUID Ease<Value>(this Clock clock, in UUID key, IInterpolator<Value> interpolator, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null)
            => clock.Ease(Queue.Default, key, interpolator, easing, duration, start, end, onUpdate, onComplete);

        public static UUID Ease<Value>(this Clock clock, Queue queue, IInterpolator<Value> interpolator, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null)
            => clock.Ease(queue, UUID.Create(), interpolator, easing, duration, start, end, onUpdate, onComplete);

        public static UUID Ease<Value>(this Clock clock, IInterpolator<Value> interpolator, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null)
            => clock.Ease(Queue.Default, UUID.Create(), interpolator, easing, duration, start, end, onUpdate, onComplete);

        public static UUID Ease<Value>(this Clock clock, Queue queue, in UUID key, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null)
            => clock.Ease(queue, key, start.CreateInterpolator(), easing, duration, start, end, onUpdate, onComplete);

        public static UUID Ease<Value>(this Clock clock, in UUID key, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null)
            => clock.Ease(Queue.Default, key, start.CreateInterpolator(), easing, duration, start, end, onUpdate, onComplete);

        public static UUID Ease<Value>(this Clock clock, Queue queue, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null)
            => clock.Ease(queue, UUID.Create(), start.CreateInterpolator(), easing, duration, start, end, onUpdate, onComplete);

        public static UUID Ease<Value>(this Clock clock, Easing easing, float duration, Value start, Value end, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.UpdateCallback onUpdate, AnimationUpdatingTimer<Value, IFixedDurationAnimation<Value>>.CompletionCallback onComplete = null)
            => clock.Ease(Queue.Default, UUID.Create(), start.CreateInterpolator(), easing, duration, start, end, onUpdate, onComplete);
    }
}
#endif