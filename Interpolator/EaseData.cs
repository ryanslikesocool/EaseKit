// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if DWL_TIMER
using Unity.Mathematics;

namespace Easings.Interpolator {
    public struct EaseData {
        private EasingType easingType;
        /// <summary>
        /// The easing type that the interpolator will use.
        /// </summary>
        public EasingType EasingType {
            get => easingType;
            set {
                easingType = value;
                function = easingType.GetFunction();
            }
        }

        private Function function;
        /// <summary>
        /// The easing function that the interpolator will use.
        /// If this is not null, the [EasingType] will be set to [EasingType.Custom].
        /// </summary>
        public Function Function {
            get => function;
            set {
                function = value;
                easingType = EasingType.Custom;
            }
        }

        private float time;
        /// <summary>
        /// The interpolator's current time.
        /// </summary>
        public float Time {
            get => time;
            set => time = math.clamp(value, 0, Duration);
        }

        /// <summary>
        /// The interpolator's initial value.
        /// </summary>
        public float Initial { get; private set; }

        /// <summary>
        /// The interpolator's target value.
        /// </summary>
        public float Target { get; private set; }

        /// <summary>
        /// The interpolator's duration.
        /// </summary>
        public float Duration { get; private set; }

        /// <summary>
        /// The interpolator's value delta. [Target - Initial]
        /// </summary>
        public float TotalDelta => Target - Initial;

        /// <summary>
        /// The change in [Value] during the last update.
        /// </summary>
        public float ValueDelta { get; private set; }

        /// <summary>
        /// The interpolator's current value.
        /// </summary>
        public float Value { get; private set; }

        /// <summary>
        /// The interpolator's completion percent. [Time / Duration]
        /// </summary>
        public float Percentage => Time / Duration;

        /// <summary>
        /// Is the interpolator done? [Time == Duration]
        /// </summary>
        public bool IsDone => Time == Duration;

        internal EaseData(float startValue, float endValue, float duration, EasingType easing = EasingType.Linear) {
            Initial = startValue;
            Target = endValue;
            ValueDelta = 0;
            Duration = duration;
            Value = duration == 0 ? endValue : startValue;
            time = 0f;
            easingType = easing;
            function = easing.GetFunction();
        }

        internal void Update(float deltaTime) {
            Time += deltaTime;
            float previousValue = Value;
            Value = math.lerp(Initial, Target, Percentage);
            ValueDelta = Value - previousValue;
        }
    }
}
#endif