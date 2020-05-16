// Made with <3 by Ryan Boyer http://ryanjboyer.com

using UnityEngine;
using System.Runtime.CompilerServices;

namespace ifelse.Easings.Entities
{
    public static class EasingFunctionsInline
    {
        public static class Linear
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Ease(float t, float b, float c, float d)
            {
                return c * t / d + b;
            }
        }

        public static class Expo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return (t == d) ? b + c : c * (-Mathf.Pow(2, -10 * t / d) + 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return (t == 0) ? b : c * Mathf.Pow(2, 10 * (t / d - 1)) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Circ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * Mathf.Sqrt(1 - (t = t / d - 1) * t) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return -c * (Mathf.Sqrt(1 - (t /= d) * t) - 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return -c / 2 * (Mathf.Sqrt(1 - t * t) - 1) + b;
                return c / 2 * (Mathf.Sqrt(1 - (t -= 2) * t) + 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Quad
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return -c * (t /= d) * (t - 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t + b;
                return -c / 2 * ((--t) * (t - 2) - 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Sine
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * Mathf.Sin(t / d * (Mathf.PI / 2)) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return -c * Mathf.Cos(t / d * (Mathf.PI / 2)) + c + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * (Mathf.Sin(Mathf.PI * t / 2)) + b;
                return -c / 2 * (Mathf.Cos(Mathf.PI * --t / 2) - 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Cubic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * ((t = t / d - 1) * t * t + 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * t + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t * t + b;
                return c / 2 * ((t -= 2) * t * t + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Quart
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return -c * ((t = t / d - 1) * t * t * t - 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * t * t + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t * t * t + b;
                return -c / 2 * ((t -= 2) * t * t * t - 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Quint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * ((t = t / d - 1) * t * t * t * t + 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * t * t * t + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                if ((t /= d / 2) < 1)
                    return c / 2 * t * t * t * t * t + b;
                return c / 2 * ((t -= 2) * t * t * t * t + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Elastic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                if ((t /= d) == 1)
                    return b + c;
                float p = d * .3f;
                float s = p / 4;
                return (c * Mathf.Pow(2, -10 * t) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p) + c + b);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                if ((t /= d) == 1)
                    return b + c;
                float p = d * .3f;
                float s = p / 4;
                return -(c * Mathf.Pow(2, 10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p)) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Bounce
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return c - EaseOut(d - t, 0, c, d) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseIn(t * 2, 0, c, d) * .5f + b;
                else
                    return EaseOut(t * 2 - d, 0, c, d) * .5f + c * .5f + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static class Back
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d)
            {
                return c * ((t = t / d - 1) * t * ((1.70158f + 1) * t + 1.70158f) + 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d)
            {
                return c * (t /= d) * t * ((1.70158f + 1) * t - 1.70158f) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
            {
                float s = 1.70158f;
                if ((t /= d / 2) < 1)
                    return c / 2 * (t * t * (((s *= (1.525f)) + 1) * t - s)) + b;
                return c / 2 * ((t -= 2) * t * (((s *= (1.525f)) + 1) * t + s) + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d)
            {
                if (t < d / 2)
                    return EaseOut(t * 2, b, c / 2, d);
                return EaseIn((t * 2) - d, b + c / 2, c / 2, d);
            }
        }
    }
}