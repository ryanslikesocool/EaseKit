// Made with <3 by Ryan Boyer http://ryanjboyer.com

namespace ifelse.Easings
{
    public class Interpolator
    {
        public float Time { get; private set; }
        public float Initial { get; private set; }
        public float TotalDelta { get; private set; }
        public float ValueDelta { get; private set; }
        public float Duration { get; private set; }
        public float Value { get; private set; }
        public float Percentage { get { return Time / Duration; } }
        public bool Done { get { return Time == Duration; } }

        private Easing.IFunction function;

        public Interpolator()
        {
            SetFunction(EasingType.Linear);
        }

        public Interpolator(EasingType easingType)
        {
            Time = 0;
            Initial = 0;
            TotalDelta = 0;
            ValueDelta = 0;
            Duration = 0;
            Value = 0;
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

        public void Update(bool unscaled = false)
        {
            float newValue = Update(unscaled ? UnityEngine.Time.unscaledDeltaTime : UnityEngine.Time.deltaTime); ;
            ValueDelta = newValue - Value;
            Value = newValue;
        }

        public float Update(float deltaTime)
        {
            Time += deltaTime;
            if (Time > Duration)
            {
                Time = Duration;
            }
            return function.Ease(Time, Initial, TotalDelta, Duration);
        }

        public void SetFunction(EasingType easingType)
        {
            function = GetFunction(easingType);
        }

        Easing.IFunction GetFunction(EasingType easing)
        {
            switch (easing)
            {
                default:
                case EasingType.Linear:
                    return Easing.LinearEase;
                case EasingType.ExpoIn:
                    return Easing.ExpoIn;
                case EasingType.ExpoOut:
                    return Easing.ExpoOut;
                case EasingType.ExpoOutIn:
                    return Easing.ExpoOutIn;
                case EasingType.ExpoInOut:
                    return Easing.ExpoInOut;
                case EasingType.CircIn:
                    return Easing.CircIn;
                case EasingType.CircOut:
                    return Easing.CircOut;
                case EasingType.CircOutIn:
                    return Easing.CircOutIn;
                case EasingType.CircInOut:
                    return Easing.CircInOut;
                case EasingType.QuadIn:
                    return Easing.QuadIn;
                case EasingType.QuadOut:
                    return Easing.QuadOut;
                case EasingType.QuadOutIn:
                    return Easing.QuadOutIn;
                case EasingType.QuadInOut:
                    return Easing.QuadInOut;
                case EasingType.SineIn:
                    return Easing.SineIn;
                case EasingType.SineOut:
                    return Easing.SineOut;
                case EasingType.SineOutIn:
                    return Easing.SineOutIn;
                case EasingType.SineInOut:
                    return Easing.SineInOut;
                case EasingType.CubicIn:
                    return Easing.CubicIn;
                case EasingType.CubicOut:
                    return Easing.CubicOut;
                case EasingType.CubicOutIn:
                    return Easing.CubicOutIn;
                case EasingType.CubicInOut:
                    return Easing.CubicInOut;
                case EasingType.QuartIn:
                    return Easing.QuartIn;
                case EasingType.QuartOut:
                    return Easing.QuartOut;
                case EasingType.QuartOutIn:
                    return Easing.QuartOutIn;
                case EasingType.QuartInOut:
                    return Easing.QuartInOut;
                case EasingType.QuintIn:
                    return Easing.QuintIn;
                case EasingType.QuintOut:
                    return Easing.QuintOut;
                case EasingType.QuintOutIn:
                    return Easing.QuintOutIn;
                case EasingType.QuintInOut:
                    return Easing.QuintInOut;
                case EasingType.ElasticIn:
                    return Easing.ElasticIn;
                case EasingType.ElasticOut:
                    return Easing.ElasticOut;
                case EasingType.ElasticOutIn:
                    return Easing.ElasticOutIn;
                case EasingType.ElasticInOut:
                    return Easing.ElasticInOut;
                case EasingType.BounceIn:
                    return Easing.BounceIn;
                case EasingType.BounceOut:
                    return Easing.BounceOut;
                case EasingType.BounceOutIn:
                    return Easing.BounceOutIn;
                case EasingType.BounceInOut:
                    return Easing.BounceInOut;
                case EasingType.BackIn:
                    return Easing.BackIn;
                case EasingType.BackOut:
                    return Easing.BackOut;
                case EasingType.BackOutIn:
                    return Easing.BackOutIn;
                case EasingType.BackInOut:
                    return Easing.BackInOut;
            }
        }
    }
}
