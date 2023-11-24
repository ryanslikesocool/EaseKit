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
			Easing.Linear => EasingUtility.LinearEase,
			Easing.ExponentialIn => EasingUtility.ExpoIn,
			Easing.ExponentialOut => EasingUtility.ExpoOut,
			Easing.ExponentialOutIn => EasingUtility.ExpoOutIn,
			Easing.ExponentialInOut => EasingUtility.ExpoInOut,
			Easing.CircularIn => EasingUtility.CircIn,
			Easing.CircularOut => EasingUtility.CircOut,
			Easing.CircularOutIn => EasingUtility.CircOutIn,
			Easing.CircularInOut => EasingUtility.CircInOut,
			Easing.QuadraticIn => EasingUtility.QuadIn,
			Easing.QuadraticOut => EasingUtility.QuadOut,
			Easing.QuadraticOutIn => EasingUtility.QuadOutIn,
			Easing.QuadraticInOut => EasingUtility.QuadInOut,
			Easing.SinusoidalIn => EasingUtility.SineIn,
			Easing.SinusoidalOut => EasingUtility.SineOut,
			Easing.SinusoidalOutIn => EasingUtility.SineOutIn,
			Easing.SinusoidalInOut => EasingUtility.SineInOut,
			Easing.CubicIn => EasingUtility.CubicIn,
			Easing.CubicOut => EasingUtility.CubicOut,
			Easing.CubicOutIn => EasingUtility.CubicOutIn,
			Easing.CubicInOut => EasingUtility.CubicInOut,
			Easing.QuarticIn => EasingUtility.QuartIn,
			Easing.QuarticOut => EasingUtility.QuartOut,
			Easing.QuarticOutIn => EasingUtility.QuartOutIn,
			Easing.QuarticInOut => EasingUtility.QuartInOut,
			Easing.QuinticIn => EasingUtility.QuintIn,
			Easing.QuinticOut => EasingUtility.QuintOut,
			Easing.QuinticOutIn => EasingUtility.QuintOutIn,
			Easing.QuinticInOut => EasingUtility.QuintInOut,
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
			_ => throw new ArgumentException($"An easing function for {easing} does not exist.  Did you pass in a valid easing function?")
		};

		/// <summary>
		/// Retrieve the inverse of the provided easing type.
		/// </summary>
		/// <param name="easing">The easing type to use.</param>
		/// <returns>The inverse of the provided easing type.</returns>
		public static Easing GetInverse(this Easing easing) => easing switch {
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
			_ => throw new ArgumentException($"An inverse easing function for {easing} does not exist.  Did you pass in a valid easing function?")
		};
	}
}