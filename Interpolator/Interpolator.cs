// Made with <3 by Ryan Boyer http://ryanjboyer.com

namespace Easings.Interpolator
{
    public class Interpolator
    {
        public EasingType EasingType { get; private set; }

        public float Time { get; private set; }
        public float Initial { get; private set; }
        public float Duration { get; private set; }

        public float TotalDelta { get; private set; }
        public float ValueDelta { get; private set; }
        public float Value { get; private set; }

        public float Percentage => Time / Duration;
        public bool Done => Time == Duration;

        private Function function;

        public Interpolator()
        {
            SetFunction(EasingType.Linear);
        }

        public Interpolator(EasingType easingType)
        {
            SetFunction(easingType);
        }

        public void Begin(float startValue, float endValue, float duration)
        {
            Initial = startValue;
            TotalDelta = endValue - startValue;
            ValueDelta = 0;
            Duration = duration;
            Value = duration == 0 ? endValue : startValue;
            Time = 0f;
        }

        public float Update(bool unscaled = false)
        {
            return Update(unscaled ? UnityEngine.Time.unscaledDeltaTime : UnityEngine.Time.deltaTime);
        }

        public float Update(float deltaTime)
        {
            Time += deltaTime;
            if (Time > Duration)
            {
                Time = Duration;
            }

            float newValue = function.Ease(Time, Initial, TotalDelta, Duration);
            ValueDelta = newValue - Value;
            Value = newValue;

            return Value;
        }

        public void SetFunction(EasingType easingType)
        {
            EasingType = easingType;
            function = easingType.GetFunction();
        }
    }
}
