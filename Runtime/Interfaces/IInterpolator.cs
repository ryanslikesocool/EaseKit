// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

namespace EaseKit {
	/// <summary>
	/// The interpolator interface.
	/// <br/>
	/// All default interpolators inherit from this interface.
	/// </summary>
	/// <remarks>
	/// Interpolators are used for linearly interpolating between two values.  Most default interpolators are built around Unity's existing Lerp methods.
	/// <br/>
	/// Interpolators should not contain fields or perform any other logic.  They are meant to be lightweight.
	/// </remarks>
	/// <typeparam name="Value">The value type to interpolate.</typeparam>
	public interface IInterpolator<Value> {
		/// <summary>
		/// Interpolate between the <paramref name="start"/> and <paramref name="end"/> values by <paramref name="percent"/>, and return the result.
		/// </summary>
		/// <param name="start">The start value, returned when <paramref name="percent"/> is <c>0.0</c>.</param>
		/// <param name="end">The end value, returned when <paramref name="percent"/> is <c>1.0</c>.</param>
		/// <param name="percent">The interpolation percent, within the range <c>[0.0 ... 1.0]</c>.</param>
		/// <returns>The interpolated value, between <paramref name="start"/> and <paramref name="end"/>.</returns>
		Value Evaluate(in Value start, in Value end, float percent);
	}
}