// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace Easings {
    public static class EasingExtensions {
        /// <summary>
        /// Ease a float with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ease(this EasingType type, float time, float start, float delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a float with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ease(this CustomEasing type, float time, float start, float delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Vector2 with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Vector2.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Ease(this EasingType type, float time, Vector2 start, Vector2 delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Vector2 with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Vector2.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Ease(this CustomEasing type, float time, Vector2 start, Vector2 delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Vector3 with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Vector3.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Ease(this EasingType type, float time, Vector3 start, Vector3 delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Vector3 with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Vector3.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Ease(this CustomEasing type, float time, Vector3 start, Vector3 delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Vector4 with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Vector4.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Ease(this EasingType type, float time, Vector4 start, Vector4 delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Vector4 with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Vector4.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Ease(this CustomEasing type, float time, Vector4 start, Vector4 delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Quaternion with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Ease(this EasingType type, float time, Quaternion start, Quaternion delta, float duration) => type.GetFunction().Ease(time, start, delta, duration);

        /// <summary>
        /// Ease a Color with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Color.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Ease(this EasingType type, float time, Color start, Color delta, float duration) => Color.Lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a Color with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased Color.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Ease(this CustomEasing type, float time, Color start, Color delta, float duration) => Color.Lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a float2 with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float2.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Ease(this EasingType type, float time, float2 start, float2 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a float2 with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float2.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Ease(this CustomEasing type, float time, float2 start, float2 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a float3 with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float3.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Ease(this EasingType type, float time, float3 start, float3 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a float3 with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float3.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Ease(this CustomEasing type, float time, float3 start, float3 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a float4 with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float4.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ease(this EasingType type, float time, float4 start, float4 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a float4 with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased float4.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 Ease(this CustomEasing type, float time, float4 start, float4 delta, float duration) => math.lerp(start, start + delta, type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a quaternion with the given easing type.
        /// </summary>
        /// <param name="type">The easing type.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion Ease(this EasingType type, float time, quaternion start, quaternion delta, float duration) => math.slerp(start, math.mul(delta, start), type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Ease a quaternion with the given custom easing.
        /// </summary>
        /// <param name="type">The custom easing asset.</param>
        /// <param name="time">The easing time.</param>
        /// <param name="start">The start value.</param>
        /// <param name="delta">The delta value.</param>
        /// <param name="duration">The duration.</param>
        /// <returns>Returns an eased quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion Ease(this CustomEasing type, float time, quaternion start, quaternion delta, float duration) => math.slerp(start, math.mul(delta, start), type.GetFunction().Ease(time, 0, 1, duration));

        /// <summary>
        /// Gets an easing function for the specified type.
        /// </summary>
        /// <param name="easing">The easing type to use.</param>
        /// <returns>Returns the easing function for the specified type.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Function GetFunction(this EasingType easing) => easing switch {
            EasingType.Linear => EasingFunctions.LinearEase,
            EasingType.ExpoIn => EasingFunctions.ExpoIn,
            EasingType.ExpoOut => EasingFunctions.ExpoOut,
            EasingType.ExpoOutIn => EasingFunctions.ExpoOutIn,
            EasingType.ExpoInOut => EasingFunctions.ExpoInOut,
            EasingType.CircIn => EasingFunctions.CircIn,
            EasingType.CircOut => EasingFunctions.CircOut,
            EasingType.CircOutIn => EasingFunctions.CircOutIn,
            EasingType.CircInOut => EasingFunctions.CircInOut,
            EasingType.QuadIn => EasingFunctions.QuadIn,
            EasingType.QuadOut => EasingFunctions.QuadOut,
            EasingType.QuadOutIn => EasingFunctions.QuadOutIn,
            EasingType.QuadInOut => EasingFunctions.QuadInOut,
            EasingType.SineIn => EasingFunctions.SineIn,
            EasingType.SineOut => EasingFunctions.SineOut,
            EasingType.SineOutIn => EasingFunctions.SineOutIn,
            EasingType.SineInOut => EasingFunctions.SineInOut,
            EasingType.CubicIn => EasingFunctions.CubicIn,
            EasingType.CubicOut => EasingFunctions.CubicOut,
            EasingType.CubicOutIn => EasingFunctions.CubicOutIn,
            EasingType.CubicInOut => EasingFunctions.CubicInOut,
            EasingType.QuartIn => EasingFunctions.QuartIn,
            EasingType.QuartOut => EasingFunctions.QuartOut,
            EasingType.QuartOutIn => EasingFunctions.QuartOutIn,
            EasingType.QuartInOut => EasingFunctions.QuartInOut,
            EasingType.QuintIn => EasingFunctions.QuintIn,
            EasingType.QuintOut => EasingFunctions.QuintOut,
            EasingType.QuintOutIn => EasingFunctions.QuintOutIn,
            EasingType.QuintInOut => EasingFunctions.QuintInOut,
            EasingType.ElasticIn => EasingFunctions.ElasticIn,
            EasingType.ElasticOut => EasingFunctions.ElasticOut,
            EasingType.ElasticOutIn => EasingFunctions.ElasticOutIn,
            EasingType.ElasticInOut => EasingFunctions.ElasticInOut,
            EasingType.BounceIn => EasingFunctions.BounceIn,
            EasingType.BounceOut => EasingFunctions.BounceOut,
            EasingType.BounceOutIn => EasingFunctions.BounceOutIn,
            EasingType.BounceInOut => EasingFunctions.BounceInOut,
            EasingType.BackIn => EasingFunctions.BackIn,
            EasingType.BackOut => EasingFunctions.BackOut,
            EasingType.BackOutIn => EasingFunctions.BackOutIn,
            EasingType.BackInOut => EasingFunctions.BackInOut,
            _ => EasingFunctions.LinearEase
        };

        /// <summary>
        /// Gets an easing function for the specified custom easing.
        /// </summary>
        /// <param name="easing">The custom easing asset to use.</param>
        /// <returns>Returns the easing function for the specified custom easing.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Function GetFunction(this CustomEasing easing) => easing.function;

        /// <summary>
        /// Get the inverse of the specified easing type.
        /// </summary>
        /// <param name="easing">The easing type to use.</param>
        /// <returns>Returns the inverse of the specified type.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EasingType Inverse(this EasingType easing) => easing switch {
            EasingType.Linear => EasingType.Linear,
            EasingType.ExpoIn => EasingType.ExpoOut,
            EasingType.ExpoOut => EasingType.ExpoIn,
            EasingType.ExpoOutIn => EasingType.ExpoInOut,
            EasingType.ExpoInOut => EasingType.ExpoOutIn,
            EasingType.CircIn => EasingType.CircOut,
            EasingType.CircOut => EasingType.CircIn,
            EasingType.CircOutIn => EasingType.CircInOut,
            EasingType.CircInOut => EasingType.CircOutIn,
            EasingType.QuadIn => EasingType.QuadOut,
            EasingType.QuadOut => EasingType.QuadIn,
            EasingType.QuadOutIn => EasingType.QuadInOut,
            EasingType.QuadInOut => EasingType.QuadOutIn,
            EasingType.SineIn => EasingType.SineOut,
            EasingType.SineOut => EasingType.SineIn,
            EasingType.SineOutIn => EasingType.SineInOut,
            EasingType.SineInOut => EasingType.SineOutIn,
            EasingType.CubicIn => EasingType.CubicOut,
            EasingType.CubicOut => EasingType.CubicIn,
            EasingType.CubicOutIn => EasingType.CubicInOut,
            EasingType.CubicInOut => EasingType.CubicOutIn,
            EasingType.QuartIn => EasingType.QuartOut,
            EasingType.QuartOut => EasingType.QuartIn,
            EasingType.QuartOutIn => EasingType.QuartInOut,
            EasingType.QuartInOut => EasingType.QuartOutIn,
            EasingType.QuintIn => EasingType.QuintOut,
            EasingType.QuintOut => EasingType.QuintIn,
            EasingType.QuintOutIn => EasingType.QuintInOut,
            EasingType.QuintInOut => EasingType.QuintOutIn,
            EasingType.ElasticIn => EasingType.ElasticOut,
            EasingType.ElasticOut => EasingType.ElasticIn,
            EasingType.ElasticOutIn => EasingType.ElasticInOut,
            EasingType.ElasticInOut => EasingType.ElasticOutIn,
            EasingType.BounceIn => EasingType.BounceOut,
            EasingType.BounceOut => EasingType.BounceIn,
            EasingType.BounceOutIn => EasingType.BounceInOut,
            EasingType.BounceInOut => EasingType.BounceOutIn,
            EasingType.BackIn => EasingType.BackOut,
            EasingType.BackOut => EasingType.BackIn,
            EasingType.BackOutIn => EasingType.BackInOut,
            EasingType.BackInOut => EasingType.BackOutIn,
            _ => EasingType.Linear
        };
    }
}