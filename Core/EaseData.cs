// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using Unity.Mathematics;

namespace Easings {
    public struct EaseData {
        private Function function;

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

        internal EaseData(float startValue, float endValue, float duration, Function easing) {
            Initial = startValue;
            Target = endValue;
            ValueDelta = 0;
            Duration = duration;
            Value = duration == 0 ? endValue : startValue;
            time = 0f;
            function = easing;
        }

        internal void Update(float deltaTime) {
            Time += deltaTime;
            float previousValue = Value;

            float t = function.Ease(Time, 0, 1, Duration);
            Value = math.lerp(Initial, Target, t);

            ValueDelta = Value - previousValue;
        }
    }
}