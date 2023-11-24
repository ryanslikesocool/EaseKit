// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EaseKit {
	public static partial class EasingUtility {
		// MARK: Base

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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Value Evaluate<Value>(Value start, Value end, float percent)
			=> Evaluate(CreateInterpolator<Value>(), start, end, percent);

		// MARK: Function

		/// <summary>
		/// Get an eased percentage from an easing function.
		/// </summary>
		/// <remarks>
		/// Some easing functions may return a value outside of the range <c>[0.0 ... 1.0]</c>, such as the <c>Back</c> and <c>Elastic</c> functions.
		/// </remarks>
		/// <param name="function">The easing function to use.</param>
		/// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
		/// <returns>The eased percentage.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Evaluate(this Function function, float percent)
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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Evaluate(this Function function, float start, float end, float percent)
			=> function.Invoke(percent, start, end - start, 1);

		// MARK: Easing

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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Evaluate(this Easing easing, float percent)
			=> Evaluate(easing.GetFunction(), percent);

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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Evaluate(this Easing easing, float start, float end, float percent)
			=> Evaluate(easing.GetFunction(), start, end, percent);

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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Value Evaluate<Value>(this Easing easing, Value start, Value end, float percent)
			=> CreateInterpolator<Value>().Evaluate(easing, start, end, percent);

		// MARK: Animation Curve

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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Evaluate(this AnimationCurve animationCurve, float start, float end, float percent) {
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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Value Evaluate<Value>(this AnimationCurve animationCurve, Value start, Value end, float percent) {
			float easePercent = animationCurve.Evaluate(percent);
			return Easing.Linear.Evaluate(start, end, easePercent);
		}

		// MARK: Spring

		// TODO
		// or maybe not because spring solvers are expensive to create, especially once a frame

		// MARK: Interpolator

		/// <summary>
		/// Get a lerped value from the range <c>[</c><paramref name="start"/><c> ... </c><paramref name="end"/><c>]</c>.
		/// </summary>
		/// <param name="interpolator">The interpolator to use.</param>
		/// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
		/// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
		/// <param name="percent">The ease percent, within the range <c>[0.0 ... 1.0]</c>.</param>
		/// <returns>The lerped value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Value Evaluate<Value>(this IInterpolator<Value> interpolator, Value start, Value end, float percent)
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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Value Evaluate<Value>(this IInterpolator<Value> interpolator, Function function, Value start, Value end, float percent) {
			float easePercent = function.Evaluate(percent);
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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Value Evaluate<Value>(this IInterpolator<Value> interpolator, Easing easing, Value start, Value end, float percent)
			=> interpolator.Evaluate(easing.GetFunction(), start, end, percent);

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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Value Evaluate<Value>(this IInterpolator<Value> interpolator, AnimationCurve animationCurve, Value start, Value end, float percent) {
			float easePercent = animationCurve.Evaluate(percent);
			return interpolator.Evaluate(start, end, easePercent);
		}
	}
}