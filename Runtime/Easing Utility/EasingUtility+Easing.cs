// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System;

namespace EaseKit {
	public static partial class EasingUtility {
		/// <summary>
		/// Retrieve the easing function for the specified type.
		/// </summary>
		/// <param name="easing">The easing type to use.</param>
		/// <returns>The easing function for the specified type.</returns>
		public static Function GetFunction(this Easing easing) => easing switch {
			Easing.Linear => LinearEase,
			Easing.ExponentialIn => ExpoIn,
			Easing.ExponentialOut => ExpoOut,
			Easing.ExponentialOutIn => ExpoOutIn,
			Easing.ExponentialInOut => ExpoInOut,
			Easing.CircularIn => CircIn,
			Easing.CircularOut => CircOut,
			Easing.CircularOutIn => CircOutIn,
			Easing.CircularInOut => CircInOut,
			Easing.QuadraticIn => QuadIn,
			Easing.QuadraticOut => QuadOut,
			Easing.QuadraticOutIn => QuadOutIn,
			Easing.QuadraticInOut => QuadInOut,
			Easing.SinusoidalIn => SineIn,
			Easing.SinusoidalOut => SineOut,
			Easing.SinusoidalOutIn => SineOutIn,
			Easing.SinusoidalInOut => SineInOut,
			Easing.CubicIn => CubicIn,
			Easing.CubicOut => CubicOut,
			Easing.CubicOutIn => CubicOutIn,
			Easing.CubicInOut => CubicInOut,
			Easing.QuarticIn => QuartIn,
			Easing.QuarticOut => QuartOut,
			Easing.QuarticOutIn => QuartOutIn,
			Easing.QuarticInOut => QuartInOut,
			Easing.QuinticIn => QuintIn,
			Easing.QuinticOut => QuintOut,
			Easing.QuinticOutIn => QuintOutIn,
			Easing.QuinticInOut => QuintInOut,
			Easing.ElasticIn => ElasticIn,
			Easing.ElasticOut => ElasticOut,
			Easing.ElasticOutIn => ElasticOutIn,
			Easing.ElasticInOut => ElasticInOut,
			Easing.BounceIn => BounceIn,
			Easing.BounceOut => BounceOut,
			Easing.BounceOutIn => BounceOutIn,
			Easing.BounceInOut => BounceInOut,
			Easing.BackIn => BackIn,
			Easing.BackOut => BackOut,
			Easing.BackOutIn => BackOutIn,
			Easing.BackInOut => BackInOut,
			_ => throw new ArgumentException($"An easing function for {easing} does not exist.  Did you pass in a valid easing function?")
		};

		/// <summary>
		/// Retrieve the inverse of the provided easing type.
		/// </summary>
		/// <param name="easing">The easing type to retrieve the inverse of.</param>
		/// <returns>The inverse of the provided easing type.</returns>
		public static Easing GetInverse(this Easing easing) => easing switch {
			Easing.Linear => Easing.Linear,
			Easing.ExponentialIn => Easing.ExponentialOut,
			Easing.ExponentialOut => Easing.ExponentialIn,
			Easing.ExponentialOutIn => Easing.ExponentialInOut,
			Easing.ExponentialInOut => Easing.ExponentialOutIn,
			Easing.CircularIn => Easing.CircularOut,
			Easing.CircularOut => Easing.CircularIn,
			Easing.CircularOutIn => Easing.CircularInOut,
			Easing.CircularInOut => Easing.CircularOutIn,
			Easing.QuadraticIn => Easing.QuadraticOut,
			Easing.QuadraticOut => Easing.QuadraticIn,
			Easing.QuadraticOutIn => Easing.QuadraticInOut,
			Easing.QuadraticInOut => Easing.QuadraticOutIn,
			Easing.SinusoidalIn => Easing.SinusoidalOut,
			Easing.SinusoidalOut => Easing.SinusoidalIn,
			Easing.SinusoidalOutIn => Easing.SinusoidalInOut,
			Easing.SinusoidalInOut => Easing.SinusoidalOutIn,
			Easing.CubicIn => Easing.CubicOut,
			Easing.CubicOut => Easing.CubicIn,
			Easing.CubicOutIn => Easing.CubicInOut,
			Easing.CubicInOut => Easing.CubicOutIn,
			Easing.QuarticIn => Easing.QuarticOut,
			Easing.QuarticOut => Easing.QuarticIn,
			Easing.QuarticOutIn => Easing.QuarticInOut,
			Easing.QuarticInOut => Easing.QuarticOutIn,
			Easing.QuinticIn => Easing.QuinticOut,
			Easing.QuinticOut => Easing.QuinticIn,
			Easing.QuinticOutIn => Easing.QuinticInOut,
			Easing.QuinticInOut => Easing.QuinticOutIn,
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
			_ => throw new ArgumentException($"An inverse easing function for {easing} does not exist.  Did you pass in a valid easing function?")
		};
	}
}