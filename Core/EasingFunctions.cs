// Made with <3 by Ryan Boyer http://ryanjboyer.com

using UnityEngine;

namespace Easings
{
    public static class EasingFunctions
    {
        public static readonly Function LinearEase = new Function(new EasingFunction(Linear.Ease));
        public static readonly Function ExpoOut = new Function(new EasingFunction(Expo.EaseOut));
        public static readonly Function ExpoIn = new Function(new EasingFunction(Expo.EaseIn));
        public static readonly Function ExpoInOut = new Function(new EasingFunction(Expo.EaseInOut));
        public static readonly Function ExpoOutIn = new Function(new EasingFunction(Expo.EaseOutIn));
        public static readonly Function CircOut = new Function(new EasingFunction(Circ.EaseOut));
        public static readonly Function CircIn = new Function(new EasingFunction(Circ.EaseIn));
        public static readonly Function CircInOut = new Function(new EasingFunction(Circ.EaseInOut));
        public static readonly Function CircOutIn = new Function(new EasingFunction(Circ.EaseOutIn));
        public static readonly Function QuadOut = new Function(new EasingFunction(Quad.EaseOut));
        public static readonly Function QuadIn = new Function(new EasingFunction(Quad.EaseIn));
        public static readonly Function QuadInOut = new Function(new EasingFunction(Quad.EaseInOut));
        public static readonly Function QuadOutIn = new Function(new EasingFunction(Quad.EaseOutIn));
        public static readonly Function SineOut = new Function(new EasingFunction(Sine.EaseOut));
        public static readonly Function SineIn = new Function(new EasingFunction(Sine.EaseIn));
        public static readonly Function SineInOut = new Function(new EasingFunction(Sine.EaseInOut));
        public static readonly Function SineOutIn = new Function(new EasingFunction(Sine.EaseOutIn));
        public static readonly Function CubicOut = new Function(new EasingFunction(Cubic.EaseOut));
        public static readonly Function CubicIn = new Function(new EasingFunction(Cubic.EaseIn));
        public static readonly Function CubicInOut = new Function(new EasingFunction(Cubic.EaseInOut));
        public static readonly Function CubicOutIn = new Function(new EasingFunction(Cubic.EaseOutIn));
        public static readonly Function QuartOut = new Function(new EasingFunction(Quart.EaseOut));
        public static readonly Function QuartIn = new Function(new EasingFunction(Quart.EaseIn));
        public static readonly Function QuartInOut = new Function(new EasingFunction(Quart.EaseInOut));
        public static readonly Function QuartOutIn = new Function(new EasingFunction(Quart.EaseOutIn));
        public static readonly Function QuintOut = new Function(new EasingFunction(Quint.EaseOut));
        public static readonly Function QuintIn = new Function(new EasingFunction(Quint.EaseIn));
        public static readonly Function QuintInOut = new Function(new EasingFunction(Quint.EaseInOut));
        public static readonly Function QuintOutIn = new Function(new EasingFunction(Quint.EaseOutIn));
        public static readonly Function ElasticOut = new Function(new EasingFunction(Elastic.EaseOut));
        public static readonly Function ElasticIn = new Function(new EasingFunction(Elastic.EaseIn));
        public static readonly Function ElasticInOut = new Function(new EasingFunction(Elastic.EaseInOut));
        public static readonly Function ElasticOutIn = new Function(new EasingFunction(Elastic.EaseOutIn));
        public static readonly Function BounceOut = new Function(new EasingFunction(Bounce.EaseOut));
        public static readonly Function BounceIn = new Function(new EasingFunction(Bounce.EaseIn));
        public static readonly Function BounceInOut = new Function(new EasingFunction(Bounce.EaseInOut));
        public static readonly Function BounceOutIn = new Function(new EasingFunction(Bounce.EaseOutIn));
        public static readonly Function BackOut = new Function(new EasingFunction(Back.EaseOut));
        public static readonly Function BackIn = new Function(new EasingFunction(Back.EaseIn));
        public static readonly Function BackInOut = new Function(new EasingFunction(Back.EaseInOut));
        public static readonly Function BackOutIn = new Function(new EasingFunction(Back.EaseOutIn));

        public static class Linear
        {
            public static float Ease(float t, float b, float c, float d)
            {
                return c * t / d + b;
            }
        }

        public static class Expo
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return (t == d) ? b + c : c * (-Mathf.Pow(2, -10 * t / d) + 1) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return (t == 0) ? b : c * Mathf.Pow(2, 10 * (t / d - 1)) + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if (t == 0)
                    return b;
                if (t == d)
                    return b + c;
                if ((t /= d / 2) < 1)
                    return c / 2 * Mathf.Pow(2, 10 * (t - 1)) + b;
                return c / 2 * (-Mathf.Pow(2, -10 * --t) + 2) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Circ
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * Mathf.Sqrt(1 - (t = t / d - 1) * t) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return -c * (Mathf.Sqrt(1 - (t /= d) * t) - 1) + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return -c / 2 * (Mathf.Sqrt(1 - t * t) - 1) + b;
                return c / 2 * (Mathf.Sqrt(1 - (t -= 2) * t) + 1) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Quad
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return -c * (t /= d) * (t - 2) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t + b;
                return -c / 2 * ((--t) * (t - 2) - 1) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Sine
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * Mathf.Sin(t / d * (Mathf.PI / 2)) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return -c * Mathf.Cos(t / d * (Mathf.PI / 2)) + c + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * (Mathf.Sin(Mathf.PI * t / 2)) + b;
                return -c / 2 * (Mathf.Cos(Mathf.PI * --t / 2) - 2) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Cubic
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * ((t = t / d - 1) * t * t + 1) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * t + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t * t + b;
                return c / 2 * ((t -= 2) * t * t + 2) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Quart
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return -c * ((t = t / d - 1) * t * t * t - 1) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * t * t + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t * t * t + b;
                return -c / 2 * ((t -= 2) * t * t * t - 2) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Quint
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * ((t = t / d - 1) * t * t * t * t + 1) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * t * t * t + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t * t * t * t + b;
                return c / 2 * ((t -= 2) * t * t * t * t + 2) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Elastic
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                if ((t /= d) == 1)
                    return b + c;
                float p = d * .3f;
                float s = p / 4;
                return (c * Mathf.Pow(2, -10 * t) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p) + c + b);
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                if ((t /= d) == 1)
                    return b + c;
                float p = d * .3f;
                float s = p / 4;
                return -(c * Mathf.Pow(2, 10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p)) + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) == 2)
                    return b + c;
                float p = d * (.3f * 1.5f);
                float s = p / 4;
                if (t < 1)
                    return -.5f * (c * Mathf.Pow(2, 10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p)) + b;
                return c * Mathf.Pow(2, -10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p) * .5f + c + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Bounce
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                if ((t /= d) < (1f / 2.75f))
                    return c * (7.5625f * t * t) + b;
                else if (t < (2f / 2.75f))
                    return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + .75f) + b;
                else if (t < (2.5f / 2.75f))
                    return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + .9375f) + b;
                else
                    return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + .984375f) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return c - EaseOut(d - t, 0, c, d) + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseIn(t * 2, 0, c, d) * .5f + b;
                else
                    return EaseOut(t * 2 - d, 0, c, d) * .5f + c * .5f + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Back
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * ((t = t / d - 1) * t * ((1.70158f + 1) * t + 1.70158f) + 1) + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * ((1.70158f + 1) * t - 1.70158f) + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                float s = 1.70158f;
                if ((t /= d / 2) < 1)
                    return c / 2 * (t * t * (((s *= (1.525f)) + 1) * t - s)) + b;
                return c / 2 * ((t -= 2) * t * (((s *= (1.525f)) + 1) * t + s) + 2) + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public interface IFunction
        {
            float Ease(float t, float b, float c, float d);
        }

        public delegate float EasingFunction(float t, float b, float c, float d);

        public struct Function : IFunction
        {
            private readonly EasingFunction function;

            public Function(EasingFunction function)
            {
                this.function = function;
            }

            public float Ease(float t, float b, float c, float d)
            {
                return function(t, b, c, d);
            }
        }

        public static Function GetFunction(EasingType easing)
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
