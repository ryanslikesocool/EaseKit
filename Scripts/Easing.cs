// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using UnityEngine;

namespace EaseKit {
	public enum Easing : byte {
		[InspectorName("Linear")] Linear,
		[InspectorName("Exponential Out")] ExponentialOut,
		[InspectorName("Exponential In")] ExponentialIn,
		[InspectorName("Exponential In Out")] ExponentialInOut,
		[InspectorName("Exponential Out In")] ExponentialOutIn,
		[InspectorName("Circular Out")] CircularOut,
		[InspectorName("Circular In")] CircularIn,
		[InspectorName("Circular In Out")] CircularInOut,
		[InspectorName("Circular Out In")] CircularOutIn,
		[InspectorName("Quadratic Out")] QuadraticOut,
		[InspectorName("Quadratic In")] QuadraticIn,
		[InspectorName("Quadratic In Out")] QuadraticInOut,
		[InspectorName("Quadratic Out In")] QuadraticOutIn,
		[InspectorName("Sine Out")] SineOut,
		[InspectorName("Sine In")] SineIn,
		[InspectorName("Sine In Out")] SineInOut,
		[InspectorName("Sine Out In")] SineOutIn,
		[InspectorName("Cubic Out")] CubicOut,
		[InspectorName("Cubic In")] CubicIn,
		[InspectorName("Cubic In Out")] CubicInOut,
		[InspectorName("Cubic Out In")] CubicOutIn,
		[InspectorName("Quartic Out")] QuarticOut,
		[InspectorName("Quartic In")] QuarticIn,
		[InspectorName("Quartic In Out")] QuarticInOut,
		[InspectorName("Quartic Out In")] QuarticOutIn,
		[InspectorName("Quintic Out")] QuinticOut,
		[InspectorName("Quintic In")] QuinticIn,
		[InspectorName("Quintic In Out")] QuinticInOut,
		[InspectorName("Quintic Out In")] QuinticOutIn,
		[InspectorName("Elastic Out")] ElasticOut,
		[InspectorName("Elastic In")] ElasticIn,
		[InspectorName("Elastic In Out")] ElasticInOut,
		[InspectorName("Elastic Out In")] ElasticOutIn,
		[InspectorName("Bounce Out")] BounceOut,
		[InspectorName("Bounce Out In")] BounceIn,
		[InspectorName("Bounce In Out")] BounceInOut,
		[InspectorName("Bounce Out In")] BounceOutIn,
		[InspectorName("Back Out")] BackOut,
		[InspectorName("Back In")] BackIn,
		[InspectorName("Back In Out")] BackInOut,
		[InspectorName("Back Out In")] BackOutIn,


		/// Equivalent to <see cref="Easing.ExponentialOut"/>
		[HideInInspector] ExpoOut = ExponentialOut,

		/// Equivalent to <see cref="Easing.ExponentialIn"/>
		[HideInInspector] ExpoIn = ExponentialIn,

		/// Equivalent to <see cref="Easing.ExponentialInOut"/>
		[HideInInspector] ExpoInOut = ExponentialInOut,

		/// Equivalent to <see cref="Easing.ExponentialOutIn"/>
		[HideInInspector] ExpoOutIn = ExponentialOutIn,

		/// Equivalent to <see cref="Easing.CircularOut"/>
		[HideInInspector] CircOut = CircularOut,

		/// Equivalent to <see cref="Easing.CircularIn"/>
		[HideInInspector] CircIn = CircularIn,

		/// Equivalent to <see cref="Easing.CircularInOut"/>
		[HideInInspector] CircInOut = CircularInOut,

		/// Equivalent to <see cref="Easing.CircularOutIn"/>
		[HideInInspector] CircOutIn = CircularOutIn,

		/// Equivalent to <see cref="Easing.QuadraticOut"/>
		[HideInInspector] QuadOut = QuadraticOut,

		/// Equivalent to <see cref="Easing.QuadraticIn"/>
		[HideInInspector] QuadIn = QuadraticIn,

		/// Equivalent to <see cref="Easing.QuadraticInOut"/>
		[HideInInspector] QuadInOut = QuadraticInOut,

		/// Equivalent to <see cref="Easing.QuadraticOutIn"/>
		[HideInInspector] QuadOutIn = QuadraticOutIn,

		/// Equivalent to <see cref="Easing.QuarticOut"/>
		[HideInInspector] QuartOut = QuarticOut,

		/// Equivalent to <see cref="Easing.QuarticIn"/>
		[HideInInspector] QuartIn = QuarticIn,

		/// Equivalent to <see cref="Easing.QuarticInOut"/>
		[HideInInspector] QuartInOut = QuarticInOut,

		/// Equivalent to <see cref="Easing.QuarticOutIn"/>
		[HideInInspector] QuartOutIn = QuarticOutIn,

		/// Equivalent to <see cref="Easing.QuinticOut"/>
		[HideInInspector] QuintOut = QuinticOut,

		/// Equivalent to <see cref="Easing.QuinticIn"/>
		[HideInInspector] QuintIn = QuinticIn,

		/// Equivalent to <see cref="Easing.QuinticInOut"/>
		[HideInInspector] QuintInOut = QuinticInOut,

		/// Equivalent to <see cref="Easing.QuinticOutIn"/>
		[HideInInspector] QuintOutIn = QuinticOutIn,
	}
}