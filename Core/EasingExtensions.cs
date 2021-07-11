// Made with <3 by Ryan Boyer http://ryanjboyer.com

using UnityEngine;
using Unity.Mathematics;
using System.Runtime.CompilerServices;

namespace Easings
{
    public static class EasingExtensions
    {
        /// <summary>
        /// Ease a float with the given easing type
        /// </summary>
        /// <param name="type">The easing type</param>
        /// <param name="time">The easing time</param>
        /// <param name="start">The start value</param>
        /// <param name="delta">The delta value</param>
        /// <param name="duration">The duration</param>
        /// <returns>Returns an eased float</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ease(this EasingType type, float time, float start, float delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Vector2 with the given easing type
        /// </summary>
        /// <param name="type">The easing type</param>
        /// <param name="time">The easing time</param>
        /// <param name="start">The start value</param>
        /// <param name="delta">The delta value</param>
        /// <param name="duration">The duration</param>
        /// <returns>Returns an eased Vector2</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Ease(this EasingType type, float time, Vector2 start, Vector2 delta, float duration)
        {
            Function func = type.GetFunction();
            return new Vector2(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration)
            );
        }

        /// <summary>
        /// Ease a Vector3 with the given easing type
        /// </summary>
        /// <param name="type">The easing type</param>
        /// <param name="time">The easing time</param>
        /// <param name="start">The start value</param>
        /// <param name="delta">The delta value</param>
        /// <param name="duration">The duration</param>
        /// <returns>Returns an eased Vector3</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Ease(this EasingType type, float time, Vector3 start, Vector3 delta, float duration)
        {
            Function func = type.GetFunction();
            return new Vector3(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration),
                func.Ease(time, start.z, delta.z, duration)
            );
        }

        /// <summary>
        /// Ease a Vector4 with the given easing type
        /// </summary>
        /// <param name="type">The easing type</param>
        /// <param name="time">The easing time</param>
        /// <param name="start">The start value</param>
        /// <param name="delta">The delta value</param>
        /// <param name="duration">The duration</param>
        /// <returns>Returns an eased Vector4</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Ease(this EasingType type, float time, Vector4 start, Vector4 delta, float duration)
        {
            Function func = type.GetFunction();
            return new Vector4(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration),
                func.Ease(time, start.z, delta.z, duration),
                func.Ease(time, start.w, delta.w, duration)
            );
        }

        /// <summary>
        /// Ease a Quaternion with the given easing type
        /// </summary>
        /// <param name="type">The easing type</param>
        /// <param name="time">The easing time</param>
        /// <param name="start">The start value</param>
        /// <param name="delta">The delta value</param>
        /// <param name="duration">The duration</param>
        /// <returns>Returns an eased Quaternion</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Ease(this EasingType type, float time, Quaternion start, Quaternion delta, float duration)
        {
            Function func = type.GetFunction();
            return new Quaternion(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration),
                func.Ease(time, start.z, delta.z, duration),
                func.Ease(time, start.w, delta.w, duration)
            );
        }

        /// <summary>
        /// Ease a Color with the given easing type
        /// </summary>
        /// <param name="type">The easing type</param>
        /// <param name="time">The easing time</param>
        /// <param name="start">The start value</param>
        /// <param name="delta">The delta value</param>
        /// <param name="duration">The duration</param>
        /// <returns>Returns an eased Color</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Ease(this EasingType type, float time, Color start, Color delta, float duration) => Color.Lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        public static float2 Ease(this EasingType type, float time, float2 start, float2 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        public static float3 Ease(this EasingType type, float time, float3 start, float3 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        public static float4 Ease(this EasingType type, float time, float4 start, float4 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        public static quaternion Ease(this EasingType type, float time, quaternion start, quaternion delta, float duration) => math.slerp(start, math.mul(delta, start), type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Gets an easing function for the specified type
        /// </summary>
        /// <param name="easing">The easing type to use</param>
        /// <returns>Returns the easing function for the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Function GetFunction(this EasingType easing)
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