// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System;
using Timer;
using UnityEngine;

namespace Easings {
    public static class SequenceExtensions {
        public static Sequence Ease(this Sequence sequence, float startValue, float endValue, float duration, EasingType easing, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) {
            Func<Coroutine> action = () => Interpolator.Ease(startValue, endValue, duration, easing, onUpdate, onDone, unscaledTime);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }

        public static Sequence Ease(this Sequence sequence, float startValue, float endValue, float duration, CustomEasing easing, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) {
            Func<Coroutine> action = () => Interpolator.Ease(startValue, endValue, duration, easing, onUpdate, onDone, unscaledTime);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }

        public static Sequence Ease(this Sequence sequence, float startValue, float endValue, float duration, EasingType easing, Func<float> deltaTime, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) {
            Func<Coroutine> action = () => Interpolator.Ease(startValue, endValue, duration, easing, deltaTime, onUpdate, onDone, unscaledTime);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }

        public static Sequence Ease(this Sequence sequence, float startValue, float endValue, float duration, CustomEasing easing, Func<float> deltaTime, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) {
            Func<Coroutine> action = () => Interpolator.Ease(startValue, endValue, duration, easing, deltaTime, onUpdate, onDone, unscaledTime);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }

        public static Sequence Ease(this Sequence sequence, float duration, EasingType easing, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) {
            Func<Coroutine> action = () => Interpolator.Ease(duration, easing, onUpdate, onDone, unscaledTime);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }

        public static Sequence Ease(this Sequence sequence, float duration, CustomEasing easing, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) {
            Func<Coroutine> action = () => Interpolator.Ease(duration, easing, onUpdate, onDone, unscaledTime);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }

        public static Sequence Ease(this Sequence sequence, float duration, EasingType easing, Func<float> deltaTime, Action<EaseData> onUpdate, Action onDone = null) {
            Func<Coroutine> action = () => Interpolator.Ease(duration, easing, deltaTime, onUpdate, onDone);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }

        public static Sequence Ease(this Sequence sequence, float duration, CustomEasing easing, Func<float> deltaTime, Action<EaseData> onUpdate, Action onDone = null) {
            Func<Coroutine> action = () => Interpolator.Ease(duration, easing, deltaTime, onUpdate, onDone);
            SequenceObjectCoroutine obj = new SequenceObjectCoroutine(action);
            return sequence.Append(obj);
        }
    }
}