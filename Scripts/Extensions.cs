// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;
#if UNITY_MATHEMATICS
using Unity.Mathematics;
#endif

namespace EaseKit {
    public static class Extensions {
        // MARK: - Functions

        // MARK: Base
        public static float Ease(this Easing easing, float percent)
            => Ease(easing.GetFunction(), percent);

        public static float Ease(this Easing easing, float start, float end, float percent)
            => Ease(easing.GetFunction(), start, end, percent);

        public static float Ease(this Functions.Function function, float percent)
            => function.Invoke(percent, 0, 1, 1);

        public static float Ease(this Functions.Function function, float start, float end, float percent)
            => function.Invoke(percent, start, end - start, 1);

        // MARK: Interpolator
        public static Value Ease<Value>(this IInterpolator<Value> interpolator, Value start, Value end, float percent)
            => interpolator.Ease(Easing.Linear, start, end, percent);

        public static Value Ease<Value>(this IInterpolator<Value> interpolator, Easing easing, Value start, Value end, float percent)
            => interpolator.Ease(easing.GetFunction(), start, end, percent);

        public static Value Ease<Value>(this IInterpolator<Value> interpolator, Functions.Function function, Value start, Value end, float percent) {
            float easePercent = function.Ease(percent);
            return interpolator.Evaluate(start, end, easePercent);
        }

        // MARK: - Interpolator

        public static IInterpolator<Value> CreateInterpolator<Value>(this Value value) {
            switch (value) {
                case float _: return new FloatInterpolator() as IInterpolator<Value>;
#if UNITY_MATHEMATICS
                case float2 _: return new Float2Interpolator() as IInterpolator<Value>;
                case float3 _: return new Float3Interpolator() as IInterpolator<Value>;
                case float4 _: return new Float4Interpolator() as IInterpolator<Value>;
                case quaternion _: return new quaternionSlerpInterpolator() as IInterpolator<Value>;
#endif
                case Vector2 _: return new Vector2Interpolator() as IInterpolator<Value>;
                case Vector3 _: return new Vector3Interpolator() as IInterpolator<Value>;
                case Vector4 _: return new Vector4Interpolator() as IInterpolator<Value>;
                case Quaternion _: return new QuaternionSlerpInterpolator() as IInterpolator<Value>;
                case Color _: return new ColorInterpolator() as IInterpolator<Value>;
                default: throw new System.Exception($"{typeof(Value)} does not have an interpolator implementation.");
            }
        }

        // MARK: - Easings

        /// <summary>
        /// Gets an easing function for the specified type.
        /// </summary>
        /// <param name="easing">The easing type to use.</param>
        /// <returns>Returns the easing function for the specified type.</returns>
        public static Functions.Function GetFunction(this Easing easing) => easing switch {
            Easing.Linear => Functions.LinearEase,
            Easing.ExpoIn => Functions.ExpoIn,
            Easing.ExpoOut => Functions.ExpoOut,
            Easing.ExpoOutIn => Functions.ExpoOutIn,
            Easing.ExpoInOut => Functions.ExpoInOut,
            Easing.CircIn => Functions.CircIn,
            Easing.CircOut => Functions.CircOut,
            Easing.CircOutIn => Functions.CircOutIn,
            Easing.CircInOut => Functions.CircInOut,
            Easing.QuadIn => Functions.QuadIn,
            Easing.QuadOut => Functions.QuadOut,
            Easing.QuadOutIn => Functions.QuadOutIn,
            Easing.QuadInOut => Functions.QuadInOut,
            Easing.SineIn => Functions.SineIn,
            Easing.SineOut => Functions.SineOut,
            Easing.SineOutIn => Functions.SineOutIn,
            Easing.SineInOut => Functions.SineInOut,
            Easing.CubicIn => Functions.CubicIn,
            Easing.CubicOut => Functions.CubicOut,
            Easing.CubicOutIn => Functions.CubicOutIn,
            Easing.CubicInOut => Functions.CubicInOut,
            Easing.QuartIn => Functions.QuartIn,
            Easing.QuartOut => Functions.QuartOut,
            Easing.QuartOutIn => Functions.QuartOutIn,
            Easing.QuartInOut => Functions.QuartInOut,
            Easing.QuintIn => Functions.QuintIn,
            Easing.QuintOut => Functions.QuintOut,
            Easing.QuintOutIn => Functions.QuintOutIn,
            Easing.QuintInOut => Functions.QuintInOut,
            Easing.ElasticIn => Functions.ElasticIn,
            Easing.ElasticOut => Functions.ElasticOut,
            Easing.ElasticOutIn => Functions.ElasticOutIn,
            Easing.ElasticInOut => Functions.ElasticInOut,
            Easing.BounceIn => Functions.BounceIn,
            Easing.BounceOut => Functions.BounceOut,
            Easing.BounceOutIn => Functions.BounceOutIn,
            Easing.BounceInOut => Functions.BounceInOut,
            Easing.BackIn => Functions.BackIn,
            Easing.BackOut => Functions.BackOut,
            Easing.BackOutIn => Functions.BackOutIn,
            Easing.BackInOut => Functions.BackInOut,
            _ => Functions.LinearEase
        };

        /// <summary>
        /// Get the inverse of the specified easing type.
        /// </summary>
        /// <param name="easing">The easing type to use.</param>
        /// <returns>Returns the inverse of the specified type.</returns>
        public static Easing Inverse(this Easing easing) => easing switch {
            Easing.Linear => Easing.Linear,
            Easing.ExpoIn => Easing.ExpoOut,
            Easing.ExpoOut => Easing.ExpoIn,
            Easing.ExpoOutIn => Easing.ExpoInOut,
            Easing.ExpoInOut => Easing.ExpoOutIn,
            Easing.CircIn => Easing.CircOut,
            Easing.CircOut => Easing.CircIn,
            Easing.CircOutIn => Easing.CircInOut,
            Easing.CircInOut => Easing.CircOutIn,
            Easing.QuadIn => Easing.QuadOut,
            Easing.QuadOut => Easing.QuadIn,
            Easing.QuadOutIn => Easing.QuadInOut,
            Easing.QuadInOut => Easing.QuadOutIn,
            Easing.SineIn => Easing.SineOut,
            Easing.SineOut => Easing.SineIn,
            Easing.SineOutIn => Easing.SineInOut,
            Easing.SineInOut => Easing.SineOutIn,
            Easing.CubicIn => Easing.CubicOut,
            Easing.CubicOut => Easing.CubicIn,
            Easing.CubicOutIn => Easing.CubicInOut,
            Easing.CubicInOut => Easing.CubicOutIn,
            Easing.QuartIn => Easing.QuartOut,
            Easing.QuartOut => Easing.QuartIn,
            Easing.QuartOutIn => Easing.QuartInOut,
            Easing.QuartInOut => Easing.QuartOutIn,
            Easing.QuintIn => Easing.QuintOut,
            Easing.QuintOut => Easing.QuintIn,
            Easing.QuintOutIn => Easing.QuintInOut,
            Easing.QuintInOut => Easing.QuintOutIn,
            Easing.ElasticIn => Easing.ElasticOut,
            Easing.ElasticOut => Easing.ElasticIn,
            Easing.ElasticOutIn => Easing.ElasticInOut,
            Easing.ElasticInOut => Easing.ElasticOutIn,
            Easing.BounceIn => Easing.BounceOut,
            Easing.BounceOut => Easing.BounceIn,
            Easing.BounceOutIn => Easing.BounceInOut,
            Easing.BounceInOut => Easing.BounceOutIn,
            Easing.BackIn => Easing.BackOut,
            Easing.BackOut => Easing.BackIn,
            Easing.BackOutIn => Easing.BackInOut,
            Easing.BackInOut => Easing.BackOutIn,
            _ => Easing.Linear
        };
    }
}