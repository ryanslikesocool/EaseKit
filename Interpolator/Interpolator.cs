// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Easings.Interpolator {
    public static class Interpolator {
        /// <summary>
        /// Start an easing animation starting with [startValue] and ending at [endValue] over [duration] (with optionally [unscaledTime]) interpolated using the [easing] function, calling [onUpdate] every frame, and optional [onDone] when complete.
        /// </summary>
        /// <param name="startValue">The value to start the ease at.</param>
        /// <param name="endValue">The value to end the ease at.</param>
        /// <param name="duration">The ease [duration].</param>
        /// <param name="easing">The predefined [easing] type to use.</param>
        /// <param name="onUpdate">The function to call every frame, passing in the current EaseData.</param>
        /// <param name="onDone">The optional function to call when the easing is done.</param>
        /// <param name="unscaledTime">Use Time.unscaledDeltaTime if true.  Otherwise use Time.deltaTime.</param>
        /// <returns>Coroutine instance in case stopping is needed.</returns>
        public static Coroutine Ease(float startValue, float endValue, float duration, EasingType easing, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) => Ease(startValue, endValue, duration, easing, () => unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime, onUpdate, onDone);

        /// <summary>
        /// Start an easing animation starting with [startValue] and ending at [endValue] over [duration] (with optionally [unscaledTime]) interpolated using the [easing] function, calling [onUpdate] every frame, and optional [onDone] when complete.
        /// </summary>
        /// <param name="startValue">The value to start the ease at.</param>
        /// <param name="endValue">The value to end the ease at.</param>
        /// <param name="duration">The ease [duration].</param>
        /// <param name="easing">The predefined [easing] type to use.</param>
        /// <param name="deltaTime">Use a custom [deltaTime] each frame.</param>
        /// <param name="onUpdate">The function to call every frame, passing in the current EaseData.</param>
        /// <param name="onDone">The optional function to call when the easing is done.</param>
        /// <returns>Coroutine instance in case stopping is needed.</returns>
        public static Coroutine Ease(float startValue, float endValue, float duration, EasingType easing, Func<float> deltaTime, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) => Ease(startValue, endValue, duration, easing, deltaTime, onUpdate, onDone);

        /// <summary>
        /// Start an easing animation starting with 0 and ending at 1 over [duration] (with optionally [unscaledTime]) interpolated using the [easing] function, calling [onUpdate] every frame, and optional [onDone] when complete.
        /// </summary>
        /// <param name="duration">The ease [duration].</param>
        /// <param name="easing">The predefined [easing] type to use.</param>
        /// <param name="onUpdate">The function to call every frame, passing in the current EaseData.</param>
        /// <param name="onDone">The optional function to call when the easing is done.</param>
        /// <param name="unscaledTime">Use Time.unscaledDeltaTime if true.  Otherwise use Time.deltaTime.</param>
        /// <returns>Coroutine instance in case stopping is needed.</returns>
        public static Coroutine Ease(float duration, EasingType easing, Action<EaseData> onUpdate, Action onDone = null, bool unscaledTime = false) => Ease(0, 1, duration, easing, () => unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime, onUpdate, onDone);

        /// <summary>
        /// Start an easing animation starting with 0 and ending at 1 over [duration] (updating by [deltaTime]) interpolated using the [easing] function, calling [onUpdate] every frame, and optional [onDone] when complete.
        /// </summary>
        /// <param name="duration">The ease [duration].</param>
        /// <param name="easing">The predefined [easing] type to use.</param>
        /// <param name="deltaTime">Use a custom [deltaTime] each frame.</param>
        /// <param name="onUpdate">The function to call every frame, passing in the current EaseData.</param>
        /// <param name="onDone">The optional function to call when the easing is done.</param>
        /// <returns>Coroutine instance in case stopping is needed.</returns>
        public static Coroutine Ease(float duration, EasingType easing, Func<float> deltaTime, Action<EaseData> onUpdate, Action onDone = null) => Ease(0, 1, duration, easing, deltaTime, onUpdate, onDone);

        private static Coroutine Ease(float startValue, float endValue, float duration, EasingType easing, Func<float> deltaTime, Action<EaseData> onUpdate, Action onDone = null) {
            return Timer.Timer.Start(Ease());

            IEnumerator Ease() {
                EaseData ease = new EaseData(startValue, endValue, duration, easing);

                while (!ease.IsDone) {
                    ease.Update(deltaTime());
                    onUpdate(ease);
                    yield return null;
                }

                if (onDone != null) {
                    onDone();
                }
            }
        }
    }
}