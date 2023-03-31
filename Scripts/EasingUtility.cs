// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;
#if UNITY_MATHEMATICS
using Unity.Mathematics;
#endif
#if FOUNDATION_PACKAGE
using Foundation;
#endif

namespace EaseKit {
    public static class EasingUtility {
        public delegate float Function(float time, float start, float delta, float duration);

        public static readonly floatInterpolator floatInterpolator = new floatInterpolator();
        public static readonly Vector2Interpolator Vector2Interpolator = new Vector2Interpolator();
        public static readonly Vector3Interpolator Vector3Interpolator = new Vector3Interpolator();
        public static readonly Vector4Interpolator Vector4Interpolator = new Vector4Interpolator();
        public static readonly QuaternionInterpolator QuaternionInterpolator = new QuaternionInterpolator();
        public static readonly ColorInterpolator ColorInterpolator = new ColorInterpolator();
#if UNITY_MATHEMATICS
        public static readonly float2Interpolator float2Interpolator = new float2Interpolator();
        public static readonly float3Interpolator float3Interpolator = new float3Interpolator();
        public static readonly float4Interpolator float4Interpolator = new float4Interpolator();
        public static readonly quaternionInterpolator quaternionInterpolator = new quaternionInterpolator();
        public static readonly doubleInterpolator doubleInterpolator = new doubleInterpolator();
        public static readonly double2Interpolator double2Interpolator = new double2Interpolator();
        public static readonly double3Interpolator double3Interpolator = new double3Interpolator();
        public static readonly double4Interpolator double4Interpolator = new double4Interpolator();
#endif
#if FOUNDATION_PACKAGE
        public static readonly ClosedRangeFloatInterpolator closedRangeFloatInterpolator = new ClosedRangeFloatInterpolator();
#endif

        // MARK: - Functions

        // MARK: - Base

        /// <summary>
        /// Get a lerped value from the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// This function may be costly, as the interpolator is created each time this function is called.
        /// For repeated use, such as in an animation, the interpolator should be cached with <see cref="CreateInterpolator"/>.
        /// </remarks>
        /// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
        /// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The lerped value.</returns>
        public static Value Ease<Value>(Value start, Value end, float percent)
            => CreateInterpolator<Value>().Ease(start, end, percent);

        // MARK: - Function

        /// <summary>
        /// Get an eased percentage from an easing function.
        /// </summary>
        /// <remarks>
        /// Some easing functions may return a value outside of the range <c>[0.0 ... 1.0]</c>, such as the <c>Back</c> and <c>Elastic</c> functions.
        /// </remarks>
        /// <param name="function">The easing function to use.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased percentage.</returns>
        public static float Ease(this Function function, float percent)
            => function.Invoke(percent, 0, 1, 1);

        /// <summary>
        /// Get an eased value from an easing function and the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// Some easing functions may return a value outside of the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>,
        /// such as the <c>Back</c> and <c>Elastic</c> functions.
        /// </remarks>
        /// <param name="function">The easing function to use.</param>
        /// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
        /// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static float Ease(this Function function, float start, float end, float percent)
            => function.Invoke(percent, start, end - start, 1);

        // MARK: - Easing

        /// <summary>
        /// Get an eased percentage from an easing type.
        /// </summary>
        /// <remarks>
        /// Some easing functions may return a value outside of the range <c>[0.0 ... 1.0]</c>, such as the <c>Back</c> and <c>Elastic</c> functions.
        /// <br/>
        /// This function may be costly, as the easing function is retrieved each time this function is called.
        /// For repeated use, such as in an animation, the easing function should be cached with <see cref="GetFunction"/>.
        /// </remarks>
        /// <param name="easing">The easing type to use.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased percentage.</returns>
        public static float Ease(this Easing easing, float percent)
            => Ease(easing.GetFunction(), percent);

        /// <summary>
        /// Get an eased value from an easing type and the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// Some easing functions may return a value outside of the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>,
        /// such as the <c>Back</c> and <c>Elastic</c> functions.
        /// <br/>
        /// This function may be costly, as the easing function is retrieved each time this function is called.
        /// For repeated use, such as in an animation, the easing function should be cached with <see cref="GetFunction"/>.
        /// </remarks>
        /// <param name="easing">The easing type to use.</param>
        /// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
        /// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static float Ease(this Easing easing, float start, float end, float percent)
            => Ease(easing.GetFunction(), start, end, percent);

        /// <summary>
        /// Get an eased value from the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// Some easing functions may return a value outside of the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>,
        /// such as the <c>Back</c> and <c>Elastic</c> functions.
        /// <br/>
        /// This function may be costly, as both the easing function and interpolator are respectively retrieved and created each time this function is called.
        /// For repeated use, such as in an animation, the easing function should be cached with <see cref="GetFunction"/> interpolator should be cached with <see cref="CreateInterpolator"/>.
        /// </remarks>
        /// <param name="easing">The easing type to use.</param>
        /// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
        /// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static Value Ease<Value>(this Easing easing, Value start, Value end, float percent)
            => CreateInterpolator<Value>().Ease(easing, start, end, percent);

        // MARK: - Animation Curve

        /// <summary>
        /// Get an eased value from an animation curve and the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// For best results, use an animation curve with the start point at <c>[0.0, 0.0]</c> and the end point at <c>[1.0, 1.0]</c>.
        /// </remarks>
        /// <param name="animationCurve">The animation curve to evaluate.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static float Ease(this AnimationCurve animationCurve, float start, float end, float percent) {
            float easePercent = animationCurve.Evaluate(percent);
            return EasingUtility.lerp(start, end, easePercent);
        }

        /// <summary>
        /// Get an eased value from an animation curve and the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// For best results, use an animation curve with the start point at <c>[0.0, 0.0]</c> and the end point at <c>[1.0, 1.0]</c>.
        /// <br/>
        /// This function may be costly, as the easing function is retrieved each time this function is called.
        /// For repeated use, such as in an animation, the easing function should be cached with <see cref="GetFunction"/>.
        /// </remarks>
        /// <param name="animationCurve">The animation curve to evaluate.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static Value Ease<Value>(this AnimationCurve animationCurve, Value start, Value end, float percent) {
            float easePercent = animationCurve.Evaluate(percent);
            return Easing.Linear.Ease(start, end, percent);
        }

        // MARK: - Spring

        // TODO
        // or maybe not because spring solvers are expensive to create, especially once a frame

        // MARK: - Interpolator

        /// <summary>
        /// Get a lerped value from the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <param name="interpolator">The interpolator to use.</param>
        /// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
        /// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The lerped value.</returns>
        public static Value Ease<Value>(this IInterpolator<Value> interpolator, Value start, Value end, float percent)
            => interpolator.Evaluate(start, end, percent);

        /// <summary>
        /// Get an eased value from the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// Some easing functions may return a value outside of the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>,
        /// such as the <c>Back</c> and <c>Elastic</c> functions.
        /// </remarks>
        /// <param name="interpolator">The interpolator to use.</param>
        /// <param name="function">The easing function to use.</param>
        /// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
        /// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static Value Ease<Value>(this IInterpolator<Value> interpolator, Function function, Value start, Value end, float percent) {
            float easePercent = function.Ease(percent);
            return interpolator.Evaluate(start, end, easePercent);
        }

        /// <summary>
        /// Get an eased value from the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// Some easing functions may return a value outside of the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>,
        /// such as the <c>Back</c> and <c>Elastic</c> functions.
        /// <br/>
        /// This function may be costly, as the easing function is retrieved each time this function is called.
        /// For repeated use, such as in an animation, the easing function should be cached with <see cref="GetFunction"/>.
        /// </remarks>
        /// <param name="interpolator">The interpolator to use.</param>
        /// <param name="easing">The easing type to use.</param>
        /// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
        /// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static Value Ease<Value>(this IInterpolator<Value> interpolator, Easing easing, Value start, Value end, float percent)
            => interpolator.Ease(easing.GetFunction(), start, end, percent);

        /// <summary>
        /// Get an eased value from an animation curve and the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
        /// </summary>
        /// <remarks>
        /// For best results, use an animation curve with the start point at <c>[0.0, 0.0]</c> and the end point at <c>[1.0, 1.0]</c>.
        /// </remarks>
        /// <param name="interpolator">The interpolator to use.</param>
        /// <param name="animationCurve">The animation curve to evaluate.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
        /// <returns>The eased value.</returns>
        public static Value Ease<Value>(this IInterpolator<Value> interpolator, AnimationCurve animationCurve, Value start, Value end, float percent) {
            float easePercent = animationCurve.Evaluate(percent);
            return interpolator.Evaluate(start, end, percent);
        }

        // MARK: - Interpolator

        /// <summary>
        /// Create a default interpolator for the provided type.
        /// </summary>
        /// <remarks>
        /// Note: Some types do not have default interpolators.  You may need to create your own interpolator (conforming to <c>IInterpolator</c>).
        /// <br/>
        /// If a default interpolator for the provided type does not exist, this function will throw.
        /// </remarks>
        /// <typeparam name="Value">The value type to create an interpolator for.</typeparam>
        /// <returns>The interpolator for the provided type.  This struct can be reused.</returns>
        public static IInterpolator<Value> CreateInterpolator<Value>() {
            switch ((Value)default) {
                case float _: return floatInterpolator as IInterpolator<Value>;
                case Vector2 _: return Vector2Interpolator as IInterpolator<Value>;
                case Vector3 _: return Vector3Interpolator as IInterpolator<Value>;
                case Vector4 _: return Vector4Interpolator as IInterpolator<Value>;
                case Quaternion _: return QuaternionInterpolator as IInterpolator<Value>;
                case Color _: return ColorInterpolator as IInterpolator<Value>;
#if UNITY_MATHEMATICS
                case float2 _: return float2Interpolator as IInterpolator<Value>;
                case float3 _: return float3Interpolator as IInterpolator<Value>;
                case float4 _: return float4Interpolator as IInterpolator<Value>;
                case double _: return doubleInterpolator as IInterpolator<Value>;
                case double2 _: return double2Interpolator as IInterpolator<Value>;
                case double3 _: return double3Interpolator as IInterpolator<Value>;
                case double4 _: return double4Interpolator as IInterpolator<Value>;
                case quaternion _: return quaternionInterpolator as IInterpolator<Value>;
#endif
#if FOUNDATION_PACKAGE
                case ClosedRange<float> _: return closedRangeFloatInterpolator as IInterpolator<Value>;
#endif
                default: throw new System.Exception($"{typeof(Value)} does not have an interpolator implementation.");
            }
        }

        // MARK: - Easings

        /// <summary>
        /// Retrieve the easing function for the specified type.
        /// </summary>
        /// <param name="easing">The easing type to use.</param>
        /// <returns>The easing function for the specified type.</returns>
        public static Function GetFunction(this Easing easing) => easing switch {
            Easing.Linear => EasingUtility.LinearEase,
            Easing.ExpoIn => EasingUtility.ExpoIn,
            Easing.ExpoOut => EasingUtility.ExpoOut,
            Easing.ExpoOutIn => EasingUtility.ExpoOutIn,
            Easing.ExpoInOut => EasingUtility.ExpoInOut,
            Easing.CircIn => EasingUtility.CircIn,
            Easing.CircOut => EasingUtility.CircOut,
            Easing.CircOutIn => EasingUtility.CircOutIn,
            Easing.CircInOut => EasingUtility.CircInOut,
            Easing.QuadIn => EasingUtility.QuadIn,
            Easing.QuadOut => EasingUtility.QuadOut,
            Easing.QuadOutIn => EasingUtility.QuadOutIn,
            Easing.QuadInOut => EasingUtility.QuadInOut,
            Easing.SineIn => EasingUtility.SineIn,
            Easing.SineOut => EasingUtility.SineOut,
            Easing.SineOutIn => EasingUtility.SineOutIn,
            Easing.SineInOut => EasingUtility.SineInOut,
            Easing.CubicIn => EasingUtility.CubicIn,
            Easing.CubicOut => EasingUtility.CubicOut,
            Easing.CubicOutIn => EasingUtility.CubicOutIn,
            Easing.CubicInOut => EasingUtility.CubicInOut,
            Easing.QuartIn => EasingUtility.QuartIn,
            Easing.QuartOut => EasingUtility.QuartOut,
            Easing.QuartOutIn => EasingUtility.QuartOutIn,
            Easing.QuartInOut => EasingUtility.QuartInOut,
            Easing.QuintIn => EasingUtility.QuintIn,
            Easing.QuintOut => EasingUtility.QuintOut,
            Easing.QuintOutIn => EasingUtility.QuintOutIn,
            Easing.QuintInOut => EasingUtility.QuintInOut,
            Easing.ElasticIn => EasingUtility.ElasticIn,
            Easing.ElasticOut => EasingUtility.ElasticOut,
            Easing.ElasticOutIn => EasingUtility.ElasticOutIn,
            Easing.ElasticInOut => EasingUtility.ElasticInOut,
            Easing.BounceIn => EasingUtility.BounceIn,
            Easing.BounceOut => EasingUtility.BounceOut,
            Easing.BounceOutIn => EasingUtility.BounceOutIn,
            Easing.BounceInOut => EasingUtility.BounceInOut,
            Easing.BackIn => EasingUtility.BackIn,
            Easing.BackOut => EasingUtility.BackOut,
            Easing.BackOutIn => EasingUtility.BackOutIn,
            Easing.BackInOut => EasingUtility.BackInOut,
            _ => EasingUtility.LinearEase
        };

        /// <summary>
        /// Retrieve the inverse of the provided easing type.
        /// </summary>
        /// <param name="easing">The easing type to use.</param>
        /// <returns>The inverse of the provided easing type.</returns>
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

        // MARK: - Functions

        // MARK: Internal

        internal delegate float f_f_delegate(float v);
        internal delegate float ff_f_delegate(float v, float n);
        internal delegate float fff_f_delegate(float x, float y, float t);
#if UNITY_MATHEMATICS
        internal const float PI = math.PI;
        internal const float TAU = PI * 2;
        internal static readonly f_f_delegate sqrt = math.sqrt;
        internal static readonly ff_f_delegate pow = math.pow;
        internal static readonly f_f_delegate exp = math.exp;
        internal static readonly f_f_delegate sin = math.sin;
        internal static readonly f_f_delegate cos = math.cos;
        internal static readonly fff_f_delegate lerp = math.lerp;
#else
        internal const float PI = Mathf.Pi;
        internal const float TAU = PI * 2;
        internal static readonly f_f_delegate sqrt = Mathf.Sqrt;
        internal static readonly ff_f_delegate pow = Mathf.Pow;
        internal static readonly f_f_delegate exp = Mathf.Exp;
        internal static readonly f_f_delegate sin = Mathf.Sin;
        internal static readonly f_f_delegate cos = Mathf.Cos;
        internal static readonly fff_f_delegate lerp = Mathf.Lerp;
#endif

        // MARK: Quick Access

        public static readonly Function LinearEase = Linear.Ease;
        public static readonly Function ExpoOut = Expo.EaseOut;
        public static readonly Function ExpoIn = Expo.EaseIn;
        public static readonly Function ExpoInOut = Expo.EaseInOut;
        public static readonly Function ExpoOutIn = Expo.EaseOutIn;
        public static readonly Function CircOut = Circ.EaseOut;
        public static readonly Function CircIn = Circ.EaseIn;
        public static readonly Function CircInOut = Circ.EaseInOut;
        public static readonly Function CircOutIn = Circ.EaseOutIn;
        public static readonly Function QuadOut = Quad.EaseOut;
        public static readonly Function QuadIn = Quad.EaseIn;
        public static readonly Function QuadInOut = Quad.EaseInOut;
        public static readonly Function QuadOutIn = Quad.EaseOutIn;
        public static readonly Function SineOut = Sine.EaseOut;
        public static readonly Function SineIn = Sine.EaseIn;
        public static readonly Function SineInOut = Sine.EaseInOut;
        public static readonly Function SineOutIn = Sine.EaseOutIn;
        public static readonly Function CubicOut = Cubic.EaseOut;
        public static readonly Function CubicIn = Cubic.EaseIn;
        public static readonly Function CubicInOut = Cubic.EaseInOut;
        public static readonly Function CubicOutIn = Cubic.EaseOutIn;
        public static readonly Function QuartOut = Quart.EaseOut;
        public static readonly Function QuartIn = Quart.EaseIn;
        public static readonly Function QuartInOut = Quart.EaseInOut;
        public static readonly Function QuartOutIn = Quart.EaseOutIn;
        public static readonly Function QuintOut = Quint.EaseOut;
        public static readonly Function QuintIn = Quint.EaseIn;
        public static readonly Function QuintInOut = Quint.EaseInOut;
        public static readonly Function QuintOutIn = Quint.EaseOutIn;
        public static readonly Function ElasticOut = Elastic.EaseOut;
        public static readonly Function ElasticIn = Elastic.EaseIn;
        public static readonly Function ElasticInOut = Elastic.EaseInOut;
        public static readonly Function ElasticOutIn = Elastic.EaseOutIn;
        public static readonly Function BounceOut = Bounce.EaseOut;
        public static readonly Function BounceIn = Bounce.EaseIn;
        public static readonly Function BounceInOut = Bounce.EaseInOut;
        public static readonly Function BounceOutIn = Bounce.EaseOutIn;
        public static readonly Function BackOut = Back.EaseOut;
        public static readonly Function BackIn = Back.EaseIn;
        public static readonly Function BackInOut = Back.EaseInOut;
        public static readonly Function BackOutIn = Back.EaseOutIn;

        // MARK: Easing Functions

        internal static class Linear {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Ease(float t, float b, float c, float d) => c * t / d + b;
        }

        internal static class Expo {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => (t == d) ? b + c : c * (-pow(2, -10 * t / d) + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => (t == 0) ? b : c * pow(2, 10 * (t / d - 1)) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if (t == 0) {
                    return b;
                }
                if (t == d) {
                    return b + c;
                }
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * pow(2, 10 * (t - 1)) + b;
                }
                return c * 0.5f * (-pow(2, -10 * --t) + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Circ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * sqrt(1 - (t = t / d - 1) * t) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => -c * (sqrt(1 - (t /= d) * t) - 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return -c * 0.5f * (sqrt(1 - t * t) - 1) + b;
                }
                return c * 0.5f * (sqrt(1 - (t -= 2) * t) + 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Quad {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => -c * (t /= d) * (t - 2) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t + b;
                }
                return -c * 0.5f * ((--t) * (t - 2) - 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Sine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * sin(t / d * (PI * 0.5f)) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => -c * cos(t / d * (PI * 0.5f)) + c + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d)
                => c * 0.5f * (1 - cos(t / d * PI)) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Cubic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * ((t = t / d - 1) * t * t + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t * t + b;
                }
                return c * 0.5f * ((t -= 2) * t * t + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Quart {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => -c * ((t = t / d - 1) * t * t * t - 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * t * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t * t * t + b;
                }
                return -c * 0.5f * ((t -= 2) * t * t * t - 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Quint {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * ((t = t / d - 1) * t * t * t * t + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * t * t * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t * t * t * t + b;
                }
                return c * 0.5f * ((t -= 2) * t * t * t * t + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Elastic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) {
                if ((t /= d) == 1) {
                    return b + c;
                }
                float p = d * 0.3f;
                float s = p * 0.5f;
                return (c * pow(2, -10 * t) * sin((t * d - s) * TAU / p) + c + b);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) {
                if ((t /= d) == 1) {
                    return b + c;
                }
                float p = d * 0.3f;
                float s = p * 0.5f;
                return -(c * pow(2, 10 * (t -= 1)) * sin((t * d - s) * TAU / p)) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) == 2) {
                    return b + c;
                }
                float p = d * (.3f * 1.5f);
                float s = p * 0.5f;
                if (t < 1) {
                    return -0.5f * (c * pow(2, 10 * (t -= 1)) * sin((t * d - s) * TAU / p)) + b;
                }
                return c * pow(2, -10 * (t -= 1)) * sin((t * d - s) * TAU / p) * 0.5f + c + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Bounce {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) {
                if ((t /= d) < (1f / 2.75f)) {
                    return c * (7.5625f * t * t) + b;
                } else if (t < (2f / 2.75f)) {
                    return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f) + b;
                } else if (t < (2.5f / 2.75f)) {
                    return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f) + b;
                } else {
                    return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f) + b;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c - EaseOut(d - t, 0, c, d) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseIn(t * 2, 0, c, d) * 0.5f + b;
                } else {
                    return EaseOut(t * 2 - d, 0, c, d) * 0.5f + c * 0.5f + b;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        internal static class Back {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * ((t = t / d - 1) * t * ((1.70158f + 1) * t + 1.70158f) + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * ((1.70158f + 1) * t - 1.70158f) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                float s = 1.70158f;
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * (t * t * (((s *= (1.525f)) + 1) * t - s)) + b;
                }
                return c * 0.5f * ((t -= 2) * t * (((s *= (1.525f)) + 1) * t + s) + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }
    }
}