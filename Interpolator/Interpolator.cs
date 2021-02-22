// Made with <3 by Ryan Boyer http://ryanjboyer.com

namespace Easings.Interpolator
{
    public class Interpolator
    {
        public EasingType EasingType { get; private set; }
        public float Time { get; private set; }
        public float Initial { get; private set; }
        public float TotalDelta { get; private set; }
        public float ValueDelta { get; private set; }
        public float Duration { get; private set; }
        public float Value { get; private set; }
        public float Percentage { get { return Time / Duration; } }
        public bool Done { get { return Time == Duration; } }

        private EasingFunctions.IFunction function;

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

        public void Update(bool unscaled = false)
        {
            float newValue = Update(unscaled ? UnityEngine.Time.unscaledDeltaTime : UnityEngine.Time.deltaTime);
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
            EasingType = easingType;
            function = GetFunction(easingType);
        }

        EasingFunctions.IFunction GetFunction(EasingType easing)
        {
            switch (easing)
            {
                default:
                case EasingType.Linear:
                    return EasingFunctions.LinearEase;
                case EasingType.ExpoIn:
                    return EasingFunctions.ExpoIn;
                case EasingType.ExpoOut:
                    return EasingFunctions.ExpoOut;
                case EasingType.ExpoOutIn:
                    return EasingFunctions.ExpoOutIn;
                case EasingType.ExpoInOut:
                    return EasingFunctions.ExpoInOut;
                case EasingType.CircIn:
                    return EasingFunctions.CircIn;
                case EasingType.CircOut:
                    return EasingFunctions.CircOut;
                case EasingType.CircOutIn:
                    return EasingFunctions.CircOutIn;
                case EasingType.CircInOut:
                    return EasingFunctions.CircInOut;
                case EasingType.QuadIn:
                    return EasingFunctions.QuadIn;
                case EasingType.QuadOut:
                    return EasingFunctions.QuadOut;
                case EasingType.QuadOutIn:
                    return EasingFunctions.QuadOutIn;
                case EasingType.QuadInOut:
                    return EasingFunctions.QuadInOut;
                case EasingType.SineIn:
                    return EasingFunctions.SineIn;
                case EasingType.SineOut:
                    return EasingFunctions.SineOut;
                case EasingType.SineOutIn:
                    return EasingFunctions.SineOutIn;
                case EasingType.SineInOut:
                    return EasingFunctions.SineInOut;
                case EasingType.CubicIn:
                    return EasingFunctions.CubicIn;
                case EasingType.CubicOut:
                    return EasingFunctions.CubicOut;
                case EasingType.CubicOutIn:
                    return EasingFunctions.CubicOutIn;
                case EasingType.CubicInOut:
                    return EasingFunctions.CubicInOut;
                case EasingType.QuartIn:
                    return EasingFunctions.QuartIn;
                case EasingType.QuartOut:
                    return EasingFunctions.QuartOut;
                case EasingType.QuartOutIn:
                    return EasingFunctions.QuartOutIn;
                case EasingType.QuartInOut:
                    return EasingFunctions.QuartInOut;
                case EasingType.QuintIn:
                    return EasingFunctions.QuintIn;
                case EasingType.QuintOut:
                    return EasingFunctions.QuintOut;
                case EasingType.QuintOutIn:
                    return EasingFunctions.QuintOutIn;
                case EasingType.QuintInOut:
                    return EasingFunctions.QuintInOut;
                case EasingType.ElasticIn:
                    return EasingFunctions.ElasticIn;
                case EasingType.ElasticOut:
                    return EasingFunctions.ElasticOut;
                case EasingType.ElasticOutIn:
                    return EasingFunctions.ElasticOutIn;
                case EasingType.ElasticInOut:
                    return EasingFunctions.ElasticInOut;
                case EasingType.BounceIn:
                    return EasingFunctions.BounceIn;
                case EasingType.BounceOut:
                    return EasingFunctions.BounceOut;
                case EasingType.BounceOutIn:
                    return EasingFunctions.BounceOutIn;
                case EasingType.BounceInOut:
                    return EasingFunctions.BounceInOut;
                case EasingType.BackIn:
                    return EasingFunctions.BackIn;
                case EasingType.BackOut:
                    return EasingFunctions.BackOut;
                case EasingType.BackOutIn:
                    return EasingFunctions.BackOutIn;
                case EasingType.BackInOut:
                    return EasingFunctions.BackInOut;
            }
        }
    }
}
