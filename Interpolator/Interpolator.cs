// Made with love by Ryan Boyer http://ryanjboyer.com <3

using System;
using UnityEngine;
using Unity.Mathematics;
using System.Collections;

namespace Easings.Interpolator
{
    public class Interpolator
    {
        private EasingType easingType = EasingType.Linear;

        /// <summary>
        /// The easing type that the interpolator will use
        /// </summary>
        public EasingType EasingType
        {
            get => easingType;
            set
            {
                easingType = value;
                function = easingType.GetFunction();
            }
        }

        /// <summary>
        /// The easing function that the interpolator will use
        /// The easing type will be set to custom
        /// </summary>
        public Function Function
        {
            get => function;
            set
            {
                function = value;
                easingType = EasingType.Custom;
            }
        }

        private float time;
        /// <summary>
        /// The interpolator's current time
        /// </summary>
        public float Time
        {
            get => time;
            set
            {
                time = value;
                Update(0);
            }
        }

        /// <summary>
        /// The interpolator's initial value
        /// </summary>
        public float Initial { get; private set; }

        /// <summary>
        /// The interpolator's target value
        /// </summary>
        public float Target { get; private set; }

        /// <summary>
        /// The interpolator's duration
        /// </summary>
        public float Duration { get; private set; }

        /// <summary>
        /// The interpolator's value delta [Target - Initial]
        /// </summary>
        public float TotalDelta { get; private set; }

        /// <summary>
        /// The change in Value during the last update
        /// </summary>
        public float ValueDelta { get; private set; }

        /// <summary>
        /// The interpolator's current value
        /// </summary>
        public float Value { get; private set; }

        /// <summary>
        /// The interpolator's completion percent [Time / Duration]
        /// </summary>
        public float Percentage => Time / Duration;

        /// <summary>
        /// Is the interpolator done? [Time == Duration]
        /// </summary>
        public bool Done => Time == Duration;

        private Function function;

        /// <summary>
        /// Initialize the interpolator with a pre-defined easing function
        /// </summary>
        /// <param name="easingType">The easing type to initialize with</param>
        public Interpolator(EasingType easingType = EasingType.Linear) => EasingType = easingType;

        /// <summary>
        /// Initialize the interpolator with a custom easing function
        /// </summary>
        /// <param name="easingFunction">The easing function to initialize with</param>
        public Interpolator(Function easingFunction) => Function = easingFunction;

        /// <summary>
        /// Prepare the Interpolator for updating
        /// </summary>
        /// <param name="startValue">The start value of the interpolator</param>
        /// <param name="endValue">The end value of the interpolator</param>
        /// <param name="duration">How long the interpolator will last</param>
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
        /// Update the interpolator with optional unscaled time
        /// </summary>
        /// <param name="unscaled">Update with unscaled time</param>
        /// <returns>Returns new Value</returns>
        public float Update(bool unscaled = false) => Update(unscaled ? UnityEngine.Time.unscaledDeltaTime : UnityEngine.Time.deltaTime);

        /// <summary>
        /// Update the interpolator with a specified delta time
        /// </summary>
        /// <param name="deltaTime">Delta time to use instead of Time.deltaTime</param>
        /// <returns>Returns new Value</returns>
        public float Update(float deltaTime)
        {
            time = math.min(Time + deltaTime, Duration);

            float newValue = function.Ease(Time, Initial, TotalDelta, Duration);
            ValueDelta = newValue - Value;
            Value = newValue;

            return Value;
        }

        /// <summary>
        /// Mark the interpolator as done
        /// </summary>
        public void SetDone() => time = Duration;

        /// <summary>
        /// Reset the interpolator time for reuse
        /// </summary>
        public void Reset() => time = 0;

        /// <summary>
        /// Reset the interpolator time for reuse with a new duration
        /// <param name="duration">How long the interpolator will last</param>
        /// </summary>
        public void Reset(float duration)
        {
            time = 0;
            Duration = duration;
        }
    }
}