// Made with <3 by Ryan Boyer http://ryanjboyer.com

using System;
using System.Runtime.CompilerServices;
using Unity.Entities;

namespace Easings.Entities
{
    public static class EntitiesExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddInterpolator(this EntityManager dstManager, Entity entity, EasingType easing)
        {
            dstManager.AddComponent<InterpolatorStartTime>(entity);
            dstManager.AddComponent<InterpolatorDuration>(entity);
            dstManager.AddComponent<InterpolatorLocalTime>(entity);
            dstManager.AddComponent<InterpolatorPercent>(entity);
            dstManager.AddComponent<InterpolatorValue>(entity);
            dstManager.AddComponent<InterpolatorDone>(entity);
            dstManager.AddComponent(entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RemoveInterpolator(this EntityManager dstManager, Entity entity, EasingType easing)
        {
            dstManager.RemoveComponent<InterpolatorStartTime>(entity);
            dstManager.RemoveComponent<InterpolatorDuration>(entity);
            dstManager.RemoveComponent<InterpolatorLocalTime>(entity);
            dstManager.RemoveComponent<InterpolatorPercent>(entity);
            dstManager.RemoveComponent<InterpolatorValue>(entity);
            dstManager.RemoveComponent<InterpolatorDone>(entity);
            dstManager.RemoveComponent(entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddEasing(this EntityManager dstManager, Entity entity, EasingType easing)
        {
            dstManager.AddComponent(entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RemoveEasing(this EntityManager dstManager, Entity entity, EasingType easing)
        {
            dstManager.RemoveComponent(entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SwapEasing(this EntityManager dstManager, Entity entity, EasingType oldEasing, EasingType newEasing)
        {
            dstManager.RemoveEasing(entity, oldEasing);
            dstManager.AddEasing(entity, newEasing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddEasing(this EntityCommandBuffer.ParallelWriter cmdBuffer, int sortKey, Entity entity, EasingType easing)
        {
            cmdBuffer.AddComponent(sortKey, entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RemoveEasing(this EntityCommandBuffer.ParallelWriter cmdBuffer, int sortKey, Entity entity, EasingType easing)
        {
            cmdBuffer.RemoveComponent(sortKey, entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SwapEasing(this EntityCommandBuffer.ParallelWriter cmdBuffer, int sortKey, Entity entity, EasingType oldEasing, EasingType newEasing)
        {
            cmdBuffer.RemoveEasing(sortKey, entity, oldEasing);
            cmdBuffer.AddEasing(sortKey, entity, newEasing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddInterpolator(this EntityCommandBuffer.ParallelWriter cmdBuffer, int sortKey, Entity entity, EasingType easing)
        {
            cmdBuffer.AddComponent<InterpolatorStartTime>(sortKey, entity);
            cmdBuffer.AddComponent<InterpolatorDuration>(sortKey, entity);
            cmdBuffer.AddComponent<InterpolatorLocalTime>(sortKey, entity);
            cmdBuffer.AddComponent<InterpolatorPercent>(sortKey, entity);
            cmdBuffer.AddComponent<InterpolatorValue>(sortKey, entity);
            cmdBuffer.AddComponent<InterpolatorDone>(sortKey, entity);
            cmdBuffer.AddComponent(sortKey, entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RemoveInterpolator(this EntityCommandBuffer.ParallelWriter cmdBuffer, int sortKey, Entity entity, EasingType easing)
        {
            cmdBuffer.RemoveComponent<InterpolatorStartTime>(sortKey, entity);
            cmdBuffer.RemoveComponent<InterpolatorDuration>(sortKey, entity);
            cmdBuffer.RemoveComponent<InterpolatorLocalTime>(sortKey, entity);
            cmdBuffer.RemoveComponent<InterpolatorPercent>(sortKey, entity);
            cmdBuffer.RemoveComponent<InterpolatorValue>(sortKey, entity);
            cmdBuffer.RemoveComponent<InterpolatorDone>(sortKey, entity);
            cmdBuffer.RemoveComponent(sortKey, entity, easing.GetComponent());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Type GetComponent(this EasingType easing)
        {
            switch (easing)
            {
                default:
                case EasingType.Linear:
                    return typeof(EaseLinear);
                case EasingType.ExpoIn:
                    return typeof(EaseExpoIn);
                case EasingType.ExpoOut:
                    return typeof(EaseExpoOut);
                case EasingType.ExpoInOut:
                    return typeof(EaseExpoInOut);
                case EasingType.ExpoOutIn:
                    return typeof(EaseExpoOutIn);
                case EasingType.CircIn:
                    return typeof(EaseCircIn);
                case EasingType.CircOut:
                    return typeof(EaseCircOut);
                case EasingType.CircInOut:
                    return typeof(EaseCircInOut);
                case EasingType.CircOutIn:
                    return typeof(EaseCircOutIn);
                case EasingType.QuadIn:
                    return typeof(EaseQuadIn);
                case EasingType.QuadOut:
                    return typeof(EaseQuadOut);
                case EasingType.QuadInOut:
                    return typeof(EaseQuadInOut);
                case EasingType.QuadOutIn:
                    return typeof(EaseQuadOutIn);
                case EasingType.SineIn:
                    return typeof(EaseSineIn);
                case EasingType.SineOut:
                    return typeof(EaseSineOut);
                case EasingType.SineInOut:
                    return typeof(EaseSineInOut);
                case EasingType.SineOutIn:
                    return typeof(EaseSineOutIn);
                case EasingType.CubicIn:
                    return typeof(EaseCubicIn);
                case EasingType.CubicOut:
                    return typeof(EaseCubicOut);
                case EasingType.CubicInOut:
                    return typeof(EaseCubicInOut);
                case EasingType.CubicOutIn:
                    return typeof(EaseCubicOutIn);
                case EasingType.QuartIn:
                    return typeof(EaseQuartIn);
                case EasingType.QuartOut:
                    return typeof(EaseQuartOut);
                case EasingType.QuartInOut:
                    return typeof(EaseQuartInOut);
                case EasingType.QuartOutIn:
                    return typeof(EaseQuartOutIn);
                case EasingType.QuintIn:
                    return typeof(EaseQuintIn);
                case EasingType.QuintOut:
                    return typeof(EaseQuintOut);
                case EasingType.QuintInOut:
                    return typeof(EaseQuintInOut);
                case EasingType.QuintOutIn:
                    return typeof(EaseQuintOutIn);
                case EasingType.ElasticIn:
                    return typeof(EaseElasticIn);
                case EasingType.ElasticOut:
                    return typeof(EaseElasticOut);
                case EasingType.ElasticInOut:
                    return typeof(EaseElasticInOut);
                case EasingType.ElasticOutIn:
                    return typeof(EaseElasticOutIn);
                case EasingType.BounceIn:
                    return typeof(EaseBounceIn);
                case EasingType.BounceOut:
                    return typeof(EaseBounceOut);
                case EasingType.BounceInOut:
                    return typeof(EaseBounceInOut);
                case EasingType.BounceOutIn:
                    return typeof(EaseBounceOutIn);
                case EasingType.BackIn:
                    return typeof(EaseBackIn);
                case EasingType.BackOut:
                    return typeof(EaseBackOut);
                case EasingType.BackInOut:
                    return typeof(EaseBackInOut);
                case EasingType.BackOutIn:
                    return typeof(EaseBackOutIn);
            }
        }
    }
}