// Made with <3 by Ryan Boyer http://ryanjboyer.com

using UnityEngine;

namespace ifelse.Easings
{
    public static class Easing
    {
        public static readonly Easing.Function LinearEase = new Easing.Function(new Easing.EasingFunction(Easing.Linear.EaseOut));
        public static readonly Easing.Function ExpoOut = new Easing.Function(new Easing.EasingFunction(Easing.Expo.EaseOut));
        public static readonly Easing.Function ExpoIn = new Easing.Function(new Easing.EasingFunction(Easing.Expo.EaseIn));
        public static readonly Easing.Function ExpoInOut = new Easing.Function(new Easing.EasingFunction(Easing.Expo.EaseInOut));
        public static readonly Easing.Function ExpoOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Expo.EaseOutIn));
        public static readonly Easing.Function CircOut = new Easing.Function(new Easing.EasingFunction(Easing.Circ.EaseOut));
        public static readonly Easing.Function CircIn = new Easing.Function(new Easing.EasingFunction(Easing.Circ.EaseIn));
        public static readonly Easing.Function CircInOut = new Easing.Function(new Easing.EasingFunction(Easing.Circ.EaseInOut));
        public static readonly Easing.Function CircOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Circ.EaseOutIn));
        public static readonly Easing.Function QuadOut = new Easing.Function(new Easing.EasingFunction(Easing.Quad.EaseOut));
        public static readonly Easing.Function QuadIn = new Easing.Function(new Easing.EasingFunction(Easing.Quad.EaseIn));
        public static readonly Easing.Function QuadInOut = new Easing.Function(new Easing.EasingFunction(Easing.Quad.EaseInOut));
        public static readonly Easing.Function QuadOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Quad.EaseOutIn));
        public static readonly Easing.Function SineOut = new Easing.Function(new Easing.EasingFunction(Easing.Sine.EaseOut));
        public static readonly Easing.Function SineIn = new Easing.Function(new Easing.EasingFunction(Easing.Sine.EaseIn));
        public static readonly Easing.Function SineInOut = new Easing.Function(new Easing.EasingFunction(Easing.Sine.EaseInOut));
        public static readonly Easing.Function SineOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Sine.EaseOutIn));
        public static readonly Easing.Function CubicOut = new Easing.Function(new Easing.EasingFunction(Easing.Cubic.EaseOut));
        public static readonly Easing.Function CubicIn = new Easing.Function(new Easing.EasingFunction(Easing.Cubic.EaseIn));
        public static readonly Easing.Function CubicInOut = new Easing.Function(new Easing.EasingFunction(Easing.Cubic.EaseInOut));
        public static readonly Easing.Function CubicOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Cubic.EaseOutIn));
        public static readonly Easing.Function QuartOut = new Easing.Function(new Easing.EasingFunction(Easing.Quart.EaseOut));
        public static readonly Easing.Function QuartIn = new Easing.Function(new Easing.EasingFunction(Easing.Quart.EaseIn));
        public static readonly Easing.Function QuartInOut = new Easing.Function(new Easing.EasingFunction(Easing.Quart.EaseInOut));
        public static readonly Easing.Function QuartOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Quart.EaseOutIn));
        public static readonly Easing.Function QuintOut = new Easing.Function(new Easing.EasingFunction(Easing.Quint.EaseOut));
        public static readonly Easing.Function QuintIn = new Easing.Function(new Easing.EasingFunction(Easing.Quint.EaseIn));
        public static readonly Easing.Function QuintInOut = new Easing.Function(new Easing.EasingFunction(Easing.Quint.EaseInOut));
        public static readonly Easing.Function QuintOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Quint.EaseOutIn));
        public static readonly Easing.Function ElasticOut = new Easing.Function(new Easing.EasingFunction(Easing.Elastic.EaseOut));
        public static readonly Easing.Function ElasticIn = new Easing.Function(new Easing.EasingFunction(Easing.Elastic.EaseIn));
        public static readonly Easing.Function ElasticInOut = new Easing.Function(new Easing.EasingFunction(Easing.Elastic.EaseInOut));
        public static readonly Easing.Function ElasticOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Elastic.EaseOutIn));
        public static readonly Easing.Function BounceOut = new Easing.Function(new Easing.EasingFunction(Easing.Bounce.EaseOut));
        public static readonly Easing.Function BounceIn = new Easing.Function(new Easing.EasingFunction(Easing.Bounce.EaseIn));
        public static readonly Easing.Function BounceInOut = new Easing.Function(new Easing.EasingFunction(Easing.Bounce.EaseInOut));
        public static readonly Easing.Function BounceOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Bounce.EaseOutIn));
        public static readonly Easing.Function BackOut = new Easing.Function(new Easing.EasingFunction(Easing.Back.EaseOut));
        public static readonly Easing.Function BackIn = new Easing.Function(new Easing.EasingFunction(Easing.Back.EaseIn));
        public static readonly Easing.Function BackInOut = new Easing.Function(new Easing.EasingFunction(Easing.Back.EaseInOut));
        public static readonly Easing.Function BackOutIn = new Easing.Function(new Easing.EasingFunction(Easing.Back.EaseOutIn));

        public static class Linear
        {
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * t / d + b;
            }

            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * t / d + b;
            }

            public static float EaseInOut(float t, float b, float c, float d)
            {
                return c * t / d + b;
            }

            public static float EaseOutIn(float t, float b, float c, float d)
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
            private readonly Easing.EasingFunction function;

            public Function(Easing.EasingFunction function)
            {
                this.function = function;
            }

            public float Ease(float t, float b, float c, float d)
            {
                return function(t, b, c, d);
            }
        }
    }
}