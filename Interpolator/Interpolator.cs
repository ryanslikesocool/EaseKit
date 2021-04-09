// Made with <3 by Ryan Boyer http://ryanjboyer.com

using System;
using UnityEngine;
using Unity.Mathematics;
using System.Collections;

namespace Easings.Interpolator
{
    public class Interpolator
    {
        public EasingType EasingType { get; private set; }

        public float Time { get; private set; }
        public float Initial { get; private set; }
        public float Target { get; private set; }
        public float Duration { get; private set; }

        public float TotalDelta { get; private set; }
        public float ValueDelta { get; private set; }
        public float Value { get; private set; }

        public float Percentage => Time / Duration;
        public bool Done => Time == Duration;

        private Function function;

        /// <summary>
        /// Initialize the Interpolator with a Linear ease
        /// </summary>
        public Interpolator()
        {
            SetFunction(EasingType.Linear);
        }

        /// <summary>
        /// Initialize the Interpolator with the defined easing type
        /// </summary>
        /// <param name="easingType">The easing type to initialize with</param>
        public Interpolator(EasingType easingType)
        {
            SetFunction(easingType);
        }

        /// <summary>
        /// Prepare the Interpolator for updating
        /// </summary>
        /// <param name="startValue">The start value of the Interpolator</param>
        /// <param name="endValue">The end value of the Interpolator</param>
        /// <param name="duration">How long the Interpolator will last</param>
        public void Begin(float startValue, float endValue, float duration)
        {
            Initial = startValue;
            Target = endValue;
            TotalDelta = endValue - startValue;
            ValueDelta = 0;
            Duration = duration;
            Value = duration == 0 ? endValue : startValue;
            Time = 0f;
        }

        /// <summary>
        /// Update the Interpolator with optional unscaled time
        /// </summary>
        /// <param name="unscaled">Update with unscaled time</param>
        /// <returns>Returns new Value</returns>
        public float Update(bool unscaled = false)
        {
            return Update(unscaled ? UnityEngine.Time.unscaledDeltaTime : UnityEngine.Time.deltaTime);
        }

        /// <summary>
        /// Update the Interpolator with a specified delta time
        /// </summary>
        /// <param name="deltaTime">Delta time to use instead of Time.deltaTime</param>
        /// <returns>Returns new Value</returns>
        public float Update(float deltaTime)
        {
            Time = math.min(Time + deltaTime, Duration);

            float newValue = function.Ease(Time, Initial, TotalDelta, Duration);
            ValueDelta = newValue - Value;
            Value = newValue;

            return Value;
        }

        /// <summary>
        /// Set the Interpolator's easing function
        /// </summary>
        /// <param name="easingType">The easing type to set</param>
        public void SetFunction(EasingType easingType)
        {
            EasingType = easingType;
            function = easingType.GetFunction();
        }
    }
}
