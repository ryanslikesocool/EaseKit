// Made with <3 by Ryan Boyer http://ryanjboyer.com

using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using Unity.Entities;

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddEasing(this EntityManager dstManager, Entity entity, EasingType easing)
        {
            switch (easing)
            {
                default:
                    dstManager.AddComponent<EaseLinear>(entity);
                    break;
                case EasingType.ExpoIn:
                    dstManager.AddComponent<EaseExpoIn>(entity);
                    break;
                case EasingType.ExpoOut:
                    dstManager.AddComponent<EaseExpoOut>(entity);
                    break;
                case EasingType.ExpoInOut:
                    dstManager.AddComponent<EaseExpoInOut>(entity);
                    break;
                case EasingType.ExpoOutIn:
                    dstManager.AddComponent<EaseExpoOutIn>(entity);
                    break;
                case EasingType.CircIn:
                    dstManager.AddComponent<EaseCircIn>(entity);
                    break;
                case EasingType.CircOut:
                    dstManager.AddComponent<EaseCircOut>(entity);
                    break;
                case EasingType.CircInOut:
                    dstManager.AddComponent<EaseCircInOut>(entity);
                    break;
                case EasingType.CircOutIn:
                    dstManager.AddComponent<EaseCircOutIn>(entity);
                    break;
                case EasingType.QuadIn:
                    dstManager.AddComponent<EaseQuadIn>(entity);
                    break;
                case EasingType.QuadOut:
                    dstManager.AddComponent<EaseQuadOut>(entity);
                    break;
                case EasingType.QuadInOut:
                    dstManager.AddComponent<EaseQuadInOut>(entity);
                    break;
                case EasingType.QuadOutIn:
                    dstManager.AddComponent<EaseQuadOutIn>(entity);
                    break;
                case EasingType.SineIn:
                    dstManager.AddComponent<EaseSineIn>(entity);
                    break;
                case EasingType.SineOut:
                    dstManager.AddComponent<EaseSineOut>(entity);
                    break;
                case EasingType.SineInOut:
                    dstManager.AddComponent<EaseSineInOut>(entity);
                    break;
                case EasingType.SineOutIn:
                    dstManager.AddComponent<EaseSineOutIn>(entity);
                    break;
                case EasingType.CubicIn:
                    dstManager.AddComponent<EaseCubicIn>(entity);
                    break;
                case EasingType.CubicOut:
                    dstManager.AddComponent<EaseCubicOut>(entity);
                    break;
                case EasingType.CubicInOut:
                    dstManager.AddComponent<EaseCubicInOut>(entity);
                    break;
                case EasingType.CubicOutIn:
                    dstManager.AddComponent<EaseCubicOutIn>(entity);
                    break;
                case EasingType.QuartIn:
                    dstManager.AddComponent<EaseQuartIn>(entity);
                    break;
                case EasingType.QuartOut:
                    dstManager.AddComponent<EaseQuartOut>(entity);
                    break;
                case EasingType.QuartInOut:
                    dstManager.AddComponent<EaseQuartInOut>(entity);
                    break;
                case EasingType.QuartOutIn:
                    dstManager.AddComponent<EaseQuartOutIn>(entity);
                    break;
                case EasingType.QuintIn:
                    dstManager.AddComponent<EaseQuintIn>(entity);
                    break;
                case EasingType.QuintOut:
                    dstManager.AddComponent<EaseQuintOut>(entity);
                    break;
                case EasingType.QuintInOut:
                    dstManager.AddComponent<EaseQuintInOut>(entity);
                    break;
                case EasingType.QuintOutIn:
                    dstManager.AddComponent<EaseQuintOutIn>(entity);
                    break;
                case EasingType.ElasticIn:
                    dstManager.AddComponent<EaseElasticIn>(entity);
                    break;
                case EasingType.ElasticOut:
                    dstManager.AddComponent<EaseElasticOut>(entity);
                    break;
                case EasingType.ElasticInOut:
                    dstManager.AddComponent<EaseElasticInOut>(entity);
                    break;
                case EasingType.ElasticOutIn:
                    dstManager.AddComponent<EaseElasticOutIn>(entity);
                    break;
                case EasingType.BounceIn:
                    dstManager.AddComponent<EaseBounceIn>(entity);
                    break;
                case EasingType.BounceOut:
                    dstManager.AddComponent<EaseBounceInOut>(entity);
                    break;
                case EasingType.BounceInOut:
                    dstManager.AddComponent<EaseBounceInOut>(entity);
                    break;
                case EasingType.BounceOutIn:
                    dstManager.AddComponent<EaseBounceOutIn>(entity);
                    break;
                case EasingType.BackIn:
                    dstManager.AddComponent<EaseBackIn>(entity);
                    break;
                case EasingType.BackOut:
                    dstManager.AddComponent<EaseBackOut>(entity);
                    break;
                case EasingType.BackInOut:
                    dstManager.AddComponent<EaseBackInOut>(entity);
                    break;
                case EasingType.BackOutIn:
                    dstManager.AddComponent<EaseBackOutIn>(entity);
                    break;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RemoveEasing(this EntityManager dstManager, Entity entity, EasingType easing)
        {
            switch (easing)
            {
                default:
                    dstManager.RemoveComponent<EaseLinear>(entity);
                    break;
                case EasingType.ExpoIn:
                    dstManager.RemoveComponent<EaseExpoIn>(entity);
                    break;
                case EasingType.ExpoOut:
                    dstManager.RemoveComponent<EaseExpoOut>(entity);
                    break;
                case EasingType.ExpoInOut:
                    dstManager.RemoveComponent<EaseExpoInOut>(entity);
                    break;
                case EasingType.ExpoOutIn:
                    dstManager.RemoveComponent<EaseExpoOutIn>(entity);
                    break;
                case EasingType.CircIn:
                    dstManager.RemoveComponent<EaseCircIn>(entity);
                    break;
                case EasingType.CircOut:
                    dstManager.RemoveComponent<EaseCircOut>(entity);
                    break;
                case EasingType.CircInOut:
                    dstManager.RemoveComponent<EaseCircInOut>(entity);
                    break;
                case EasingType.CircOutIn:
                    dstManager.RemoveComponent<EaseCircOutIn>(entity);
                    break;
                case EasingType.QuadIn:
                    dstManager.RemoveComponent<EaseQuadIn>(entity);
                    break;
                case EasingType.QuadOut:
                    dstManager.RemoveComponent<EaseQuadOut>(entity);
                    break;
                case EasingType.QuadInOut:
                    dstManager.RemoveComponent<EaseQuadInOut>(entity);
                    break;
                case EasingType.QuadOutIn:
                    dstManager.RemoveComponent<EaseQuadOutIn>(entity);
                    break;
                case EasingType.SineIn:
                    dstManager.RemoveComponent<EaseSineIn>(entity);
                    break;
                case EasingType.SineOut:
                    dstManager.RemoveComponent<EaseSineOut>(entity);
                    break;
                case EasingType.SineInOut:
                    dstManager.RemoveComponent<EaseSineInOut>(entity);
                    break;
                case EasingType.SineOutIn:
                    dstManager.RemoveComponent<EaseSineOutIn>(entity);
                    break;
                case EasingType.CubicIn:
                    dstManager.RemoveComponent<EaseCubicIn>(entity);
                    break;
                case EasingType.CubicOut:
                    dstManager.RemoveComponent<EaseCubicOut>(entity);
                    break;
                case EasingType.CubicInOut:
                    dstManager.RemoveComponent<EaseCubicInOut>(entity);
                    break;
                case EasingType.CubicOutIn:
                    dstManager.RemoveComponent<EaseCubicOutIn>(entity);
                    break;
                case EasingType.QuartIn:
                    dstManager.RemoveComponent<EaseQuartIn>(entity);
                    break;
                case EasingType.QuartOut:
                    dstManager.RemoveComponent<EaseQuartOut>(entity);
                    break;
                case EasingType.QuartInOut:
                    dstManager.RemoveComponent<EaseQuartInOut>(entity);
                    break;
                case EasingType.QuartOutIn:
                    dstManager.RemoveComponent<EaseQuartOutIn>(entity);
                    break;
                case EasingType.QuintIn:
                    dstManager.RemoveComponent<EaseQuintIn>(entity);
                    break;
                case EasingType.QuintOut:
                    dstManager.RemoveComponent<EaseQuintOut>(entity);
                    break;
                case EasingType.QuintInOut:
                    dstManager.RemoveComponent<EaseQuintInOut>(entity);
                    break;
                case EasingType.QuintOutIn:
                    dstManager.RemoveComponent<EaseQuintOutIn>(entity);
                    break;
                case EasingType.ElasticIn:
                    dstManager.RemoveComponent<EaseElasticIn>(entity);
                    break;
                case EasingType.ElasticOut:
                    dstManager.RemoveComponent<EaseElasticOut>(entity);
                    break;
                case EasingType.ElasticInOut:
                    dstManager.RemoveComponent<EaseElasticInOut>(entity);
                    break;
                case EasingType.ElasticOutIn:
                    dstManager.RemoveComponent<EaseElasticOutIn>(entity);
                    break;
                case EasingType.BounceIn:
                    dstManager.RemoveComponent<EaseBounceIn>(entity);
                    break;
                case EasingType.BounceOut:
                    dstManager.RemoveComponent<EaseBounceInOut>(entity);
                    break;
                case EasingType.BounceInOut:
                    dstManager.RemoveComponent<EaseBounceInOut>(entity);
                    break;
                case EasingType.BounceOutIn:
                    dstManager.RemoveComponent<EaseBounceOutIn>(entity);
                    break;
                case EasingType.BackIn:
                    dstManager.RemoveComponent<EaseBackIn>(entity);
                    break;
                case EasingType.BackOut:
                    dstManager.RemoveComponent<EaseBackOut>(entity);
                    break;
                case EasingType.BackInOut:
                    dstManager.RemoveComponent<EaseBackInOut>(entity);
                    break;
                case EasingType.BackOutIn:
                    dstManager.RemoveComponent<EaseBackOutIn>(entity);
                    break;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddEasing(this EntityCommandBuffer.Concurrent cmdBuffer, int jobIndex, Entity entity, EasingType easing)
        {
            switch (easing)
            {
                default:
                    cmdBuffer.AddComponent<EaseLinear>(jobIndex, entity);
                    break;
                case EasingType.ExpoIn:
                    cmdBuffer.AddComponent<EaseExpoIn>(jobIndex, entity);
                    break;
                case EasingType.ExpoOut:
                    cmdBuffer.AddComponent<EaseExpoOut>(jobIndex, entity);
                    break;
                case EasingType.ExpoInOut:
                    cmdBuffer.AddComponent<EaseExpoInOut>(jobIndex, entity);
                    break;
                case EasingType.ExpoOutIn:
                    cmdBuffer.AddComponent<EaseExpoOutIn>(jobIndex, entity);
                    break;
                case EasingType.CircIn:
                    cmdBuffer.AddComponent<EaseCircIn>(jobIndex, entity);
                    break;
                case EasingType.CircOut:
                    cmdBuffer.AddComponent<EaseCircOut>(jobIndex, entity);
                    break;
                case EasingType.CircInOut:
                    cmdBuffer.AddComponent<EaseCircInOut>(jobIndex, entity);
                    break;
                case EasingType.CircOutIn:
                    cmdBuffer.AddComponent<EaseCircOutIn>(jobIndex, entity);
                    break;
                case EasingType.QuadIn:
                    cmdBuffer.AddComponent<EaseQuadIn>(jobIndex, entity);
                    break;
                case EasingType.QuadOut:
                    cmdBuffer.AddComponent<EaseQuadOut>(jobIndex, entity);
                    break;
                case EasingType.QuadInOut:
                    cmdBuffer.AddComponent<EaseQuadInOut>(jobIndex, entity);
                    break;
                case EasingType.QuadOutIn:
                    cmdBuffer.AddComponent<EaseQuadOutIn>(jobIndex, entity);
                    break;
                case EasingType.SineIn:
                    cmdBuffer.AddComponent<EaseSineIn>(jobIndex, entity);
                    break;
                case EasingType.SineOut:
                    cmdBuffer.AddComponent<EaseSineOut>(jobIndex, entity);
                    break;
                case EasingType.SineInOut:
                    cmdBuffer.AddComponent<EaseSineInOut>(jobIndex, entity);
                    break;
                case EasingType.SineOutIn:
                    cmdBuffer.AddComponent<EaseSineOutIn>(jobIndex, entity);
                    break;
                case EasingType.CubicIn:
                    cmdBuffer.AddComponent<EaseCubicIn>(jobIndex, entity);
                    break;
                case EasingType.CubicOut:
                    cmdBuffer.AddComponent<EaseCubicOut>(jobIndex, entity);
                    break;
                case EasingType.CubicInOut:
                    cmdBuffer.AddComponent<EaseCubicInOut>(jobIndex, entity);
                    break;
                case EasingType.CubicOutIn:
                    cmdBuffer.AddComponent<EaseCubicOutIn>(jobIndex, entity);
                    break;
                case EasingType.QuartIn:
                    cmdBuffer.AddComponent<EaseQuartIn>(jobIndex, entity);
                    break;
                case EasingType.QuartOut:
                    cmdBuffer.AddComponent<EaseQuartOut>(jobIndex, entity);
                    break;
                case EasingType.QuartInOut:
                    cmdBuffer.AddComponent<EaseQuartInOut>(jobIndex, entity);
                    break;
                case EasingType.QuartOutIn:
                    cmdBuffer.AddComponent<EaseQuartOutIn>(jobIndex, entity);
                    break;
                case EasingType.QuintIn:
                    cmdBuffer.AddComponent<EaseQuintIn>(jobIndex, entity);
                    break;
                case EasingType.QuintOut:
                    cmdBuffer.AddComponent<EaseQuintOut>(jobIndex, entity);
                    break;
                case EasingType.QuintInOut:
                    cmdBuffer.AddComponent<EaseQuintInOut>(jobIndex, entity);
                    break;
                case EasingType.QuintOutIn:
                    cmdBuffer.AddComponent<EaseQuintOutIn>(jobIndex, entity);
                    break;
                case EasingType.ElasticIn:
                    cmdBuffer.AddComponent<EaseElasticIn>(jobIndex, entity);
                    break;
                case EasingType.ElasticOut:
                    cmdBuffer.AddComponent<EaseElasticOut>(jobIndex, entity);
                    break;
                case EasingType.ElasticInOut:
                    cmdBuffer.AddComponent<EaseElasticInOut>(jobIndex, entity);
                    break;
                case EasingType.ElasticOutIn:
                    cmdBuffer.AddComponent<EaseElasticOutIn>(jobIndex, entity);
                    break;
                case EasingType.BounceIn:
                    cmdBuffer.AddComponent<EaseBounceIn>(jobIndex, entity);
                    break;
                case EasingType.BounceOut:
                    cmdBuffer.AddComponent<EaseBounceInOut>(jobIndex, entity);
                    break;
                case EasingType.BounceInOut:
                    cmdBuffer.AddComponent<EaseBounceInOut>(jobIndex, entity);
                    break;
                case EasingType.BounceOutIn:
                    cmdBuffer.AddComponent<EaseBounceOutIn>(jobIndex, entity);
                    break;
                case EasingType.BackIn:
                    cmdBuffer.AddComponent<EaseBackIn>(jobIndex, entity);
                    break;
                case EasingType.BackOut:
                    cmdBuffer.AddComponent<EaseBackOut>(jobIndex, entity);
                    break;
                case EasingType.BackInOut:
                    cmdBuffer.AddComponent<EaseBackInOut>(jobIndex, entity);
                    break;
                case EasingType.BackOutIn:
                    cmdBuffer.AddComponent<EaseBackOutIn>(jobIndex, entity);
                    break;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RemoveEasing(this EntityCommandBuffer.Concurrent dstManager, int jobIndex, Entity entity, EasingType easing)
        {
            switch (easing)
            {
                default:
                    dstManager.RemoveComponent<EaseLinear>(jobIndex, entity);
                    break;
                case EasingType.ExpoIn:
                    dstManager.RemoveComponent<EaseExpoIn>(jobIndex, entity);
                    break;
                case EasingType.ExpoOut:
                    dstManager.RemoveComponent<EaseExpoOut>(jobIndex, entity);
                    break;
                case EasingType.ExpoInOut:
                    dstManager.RemoveComponent<EaseExpoInOut>(jobIndex, entity);
                    break;
                case EasingType.ExpoOutIn:
                    dstManager.RemoveComponent<EaseExpoOutIn>(jobIndex, entity);
                    break;
                case EasingType.CircIn:
                    dstManager.RemoveComponent<EaseCircIn>(jobIndex, entity);
                    break;
                case EasingType.CircOut:
                    dstManager.RemoveComponent<EaseCircOut>(jobIndex, entity);
                    break;
                case EasingType.CircInOut:
                    dstManager.RemoveComponent<EaseCircInOut>(jobIndex, entity);
                    break;
                case EasingType.CircOutIn:
                    dstManager.RemoveComponent<EaseCircOutIn>(jobIndex, entity);
                    break;
                case EasingType.QuadIn:
                    dstManager.RemoveComponent<EaseQuadIn>(jobIndex, entity);
                    break;
                case EasingType.QuadOut:
                    dstManager.RemoveComponent<EaseQuadOut>(jobIndex, entity);
                    break;
                case EasingType.QuadInOut:
                    dstManager.RemoveComponent<EaseQuadInOut>(jobIndex, entity);
                    break;
                case EasingType.QuadOutIn:
                    dstManager.RemoveComponent<EaseQuadOutIn>(jobIndex, entity);
                    break;
                case EasingType.SineIn:
                    dstManager.RemoveComponent<EaseSineIn>(jobIndex, entity);
                    break;
                case EasingType.SineOut:
                    dstManager.RemoveComponent<EaseSineOut>(jobIndex, entity);
                    break;
                case EasingType.SineInOut:
                    dstManager.RemoveComponent<EaseSineInOut>(jobIndex, entity);
                    break;
                case EasingType.SineOutIn:
                    dstManager.RemoveComponent<EaseSineOutIn>(jobIndex, entity);
                    break;
                case EasingType.CubicIn:
                    dstManager.RemoveComponent<EaseCubicIn>(jobIndex, entity);
                    break;
                case EasingType.CubicOut:
                    dstManager.RemoveComponent<EaseCubicOut>(jobIndex, entity);
                    break;
                case EasingType.CubicInOut:
                    dstManager.RemoveComponent<EaseCubicInOut>(jobIndex, entity);
                    break;
                case EasingType.CubicOutIn:
                    dstManager.RemoveComponent<EaseCubicOutIn>(jobIndex, entity);
                    break;
                case EasingType.QuartIn:
                    dstManager.RemoveComponent<EaseQuartIn>(jobIndex, entity);
                    break;
                case EasingType.QuartOut:
                    dstManager.RemoveComponent<EaseQuartOut>(jobIndex, entity);
                    break;
                case EasingType.QuartInOut:
                    dstManager.RemoveComponent<EaseQuartInOut>(jobIndex, entity);
                    break;
                case EasingType.QuartOutIn:
                    dstManager.RemoveComponent<EaseQuartOutIn>(jobIndex, entity);
                    break;
                case EasingType.QuintIn:
                    dstManager.RemoveComponent<EaseQuintIn>(jobIndex, entity);
                    break;
                case EasingType.QuintOut:
                    dstManager.RemoveComponent<EaseQuintOut>(jobIndex, entity);
                    break;
                case EasingType.QuintInOut:
                    dstManager.RemoveComponent<EaseQuintInOut>(jobIndex, entity);
                    break;
                case EasingType.QuintOutIn:
                    dstManager.RemoveComponent<EaseQuintOutIn>(jobIndex, entity);
                    break;
                case EasingType.ElasticIn:
                    dstManager.RemoveComponent<EaseElasticIn>(jobIndex, entity);
                    break;
                case EasingType.ElasticOut:
                    dstManager.RemoveComponent<EaseElasticOut>(jobIndex, entity);
                    break;
                case EasingType.ElasticInOut:
                    dstManager.RemoveComponent<EaseElasticInOut>(jobIndex, entity);
                    break;
                case EasingType.ElasticOutIn:
                    dstManager.RemoveComponent<EaseElasticOutIn>(jobIndex, entity);
                    break;
                case EasingType.BounceIn:
                    dstManager.RemoveComponent<EaseBounceIn>(jobIndex, entity);
                    break;
                case EasingType.BounceOut:
                    dstManager.RemoveComponent<EaseBounceInOut>(jobIndex, entity);
                    break;
                case EasingType.BounceInOut:
                    dstManager.RemoveComponent<EaseBounceInOut>(jobIndex, entity);
                    break;
                case EasingType.BounceOutIn:
                    dstManager.RemoveComponent<EaseBounceOutIn>(jobIndex, entity);
                    break;
                case EasingType.BackIn:
                    dstManager.RemoveComponent<EaseBackIn>(jobIndex, entity);
                    break;
                case EasingType.BackOut:
                    dstManager.RemoveComponent<EaseBackOut>(jobIndex, entity);
                    break;
                case EasingType.BackInOut:
                    dstManager.RemoveComponent<EaseBackInOut>(jobIndex, entity);
                    break;
                case EasingType.BackOutIn:
                    dstManager.RemoveComponent<EaseBackOutIn>(jobIndex, entity);
                    break;
            }
        }
    }
}