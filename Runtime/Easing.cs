// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using UnityEngine;

namespace EaseKit {
	public enum Easing : byte {
		[InspectorName("Linear")] Linear,
		[InspectorName("Exponential/Out")] ExponentialOut,
		[InspectorName("Exponential/In")] ExponentialIn,
		[InspectorName("Exponential/In Out")] ExponentialInOut,
		[InspectorName("Exponential/Out In")] ExponentialOutIn,
		[InspectorName("Circular/Out")] CircularOut,
		[InspectorName("Circular/In")] CircularIn,
		[InspectorName("Circular/In Out")] CircularInOut,
		[InspectorName("Circular/Out In")] CircularOutIn,
		[InspectorName("Quadratic/Out")] QuadraticOut,
		[InspectorName("Quadratic/In")] QuadraticIn,
		[InspectorName("Quadratic/In Out")] QuadraticInOut,
		[InspectorName("Quadratic/Out In")] QuadraticOutIn,
		[InspectorName("Sinusoidal/Out")] SinusoidalOut,
		[InspectorName("Sinusoidal/In")] SinusoidalIn,
		[InspectorName("Sinusoidal/In Out")] SinusoidalInOut,
		[InspectorName("Sinusoidal/Out In")] SinusoidalOutIn,
		[InspectorName("Cubic/Out")] CubicOut,
		[InspectorName("Cubic/In")] CubicIn,
		[InspectorName("Cubic/In Out")] CubicInOut,
		[InspectorName("Cubic/Out In")] CubicOutIn,
		[InspectorName("Quartic/Out")] QuarticOut,
		[InspectorName("Quartic/In")] QuarticIn,
		[InspectorName("Quartic/In Out")] QuarticInOut,
		[InspectorName("Quartic/Out In")] QuarticOutIn,
		[InspectorName("Quintic/Out")] QuinticOut,
		[InspectorName("Quintic/In")] QuinticIn,
		[InspectorName("Quintic/In Out")] QuinticInOut,
		[InspectorName("Quintic/Out In")] QuinticOutIn,
		[InspectorName("Elastic/Out")] ElasticOut,
		[InspectorName("Elastic/In")] ElasticIn,
		[InspectorName("Elastic/In Out")] ElasticInOut,
		[InspectorName("Elastic/Out In")] ElasticOutIn,
		[InspectorName("Bounce/Out")] BounceOut,
		[InspectorName("Bounce/Out In")] BounceIn,
		[InspectorName("Bounce/In Out")] BounceInOut,
		[InspectorName("Bounce/Out In")] BounceOutIn,
		[InspectorName("Back/Out")] BackOut,
		[InspectorName("Back/In")] BackIn,
		[InspectorName("Back/In Out")] BackInOut,
		[InspectorName("Back/Out In")] BackOutIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.ExponentialOut"/>
		/// </summary>
		[HideInInspector] ExpoOut = ExponentialOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.ExponentialIn"/>
		/// </summary>
		[HideInInspector] ExpoIn = ExponentialIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.ExponentialInOut"/>
		/// </summary>
		[HideInInspector] ExpoInOut = ExponentialInOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.ExponentialOutIn"/>
		/// </summary>
		[HideInInspector] ExpoOutIn = ExponentialOutIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.CircularOut"/>
		/// </summary>
		[HideInInspector] CircOut = CircularOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.CircularIn"/>
		/// </summary>
		[HideInInspector] CircIn = CircularIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.CircularInOut"/>
		/// </summary>
		[HideInInspector] CircInOut = CircularInOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.CircularOutIn"/>
		/// </summary>
		[HideInInspector] CircOutIn = CircularOutIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuadraticOut"/>
		/// </summary>
		[HideInInspector] QuadOut = QuadraticOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuadraticIn"/>
		/// </summary>
		[HideInInspector] QuadIn = QuadraticIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuadraticInOut"/>
		/// </summary>
		[HideInInspector] QuadInOut = QuadraticInOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuadraticOutIn"/>
		/// </summary>
		[HideInInspector] QuadOutIn = QuadraticOutIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.SinusoidalOut"/>
		/// </summary>
		[HideInInspector] SineOut = SinusoidalOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.SinusoidalIn"/>
		/// </summary>
		[HideInInspector] SineIn = SinusoidalIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.SinusoidalInOut"/>
		/// </summary>
		[HideInInspector] SineInOut = SinusoidalInOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.SinusoidalOutIn"/>
		/// </summary>
		[HideInInspector] SineOutIn = SinusoidalOutIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuarticOut"/>
		/// </summary>
		[HideInInspector] QuartOut = QuarticOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuarticIn"/>
		/// </summary>
		[HideInInspector] QuartIn = QuarticIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuarticInOut"/>
		/// </summary>
		[HideInInspector] QuartInOut = QuarticInOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuarticOutIn"/>
		/// </summary>
		[HideInInspector] QuartOutIn = QuarticOutIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuinticOut"/>
		/// </summary>
		[HideInInspector] QuintOut = QuinticOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuinticIn"/>
		/// </summary>
		[HideInInspector] QuintIn = QuinticIn,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuinticInOut"/>
		/// </summary>
		[HideInInspector] QuintInOut = QuinticInOut,

		/// <summary>
		/// Equivalent to <see cref="Easing.QuinticOutIn"/>
		/// </summary>
		[HideInInspector] QuintOutIn = QuinticOutIn,
	}
}