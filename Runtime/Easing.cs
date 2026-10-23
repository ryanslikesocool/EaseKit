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
		[InspectorName("Bounce/In")] BounceIn,
		[InspectorName("Bounce/In Out")] BounceInOut,
		[InspectorName("Bounce/Out In")] BounceOutIn,
		[InspectorName("Back/Out")] BackOut,
		[InspectorName("Back/In")] BackIn,
		[InspectorName("Back/In Out")] BackInOut,
		[InspectorName("Back/Out In")] BackOutIn,

		/// <summary>
		/// This value is equivalent to <see cref="ExponentialOut"/>
		/// </summary>
		[HideInInspector] ExpoOut = ExponentialOut,

		/// <summary>
		/// This value is equivalent to <see cref="ExponentialIn"/>
		/// </summary>
		[HideInInspector] ExpoIn = ExponentialIn,

		/// <summary>
		/// This value is equivalent to <see cref="ExponentialInOut"/>
		/// </summary>
		[HideInInspector] ExpoInOut = ExponentialInOut,

		/// <summary>
		/// This value is equivalent to <see cref="ExponentialOutIn"/>
		/// </summary>
		[HideInInspector] ExpoOutIn = ExponentialOutIn,

		/// <summary>
		/// This value is equivalent to <see cref="CircularOut"/>
		/// </summary>
		[HideInInspector] CircOut = CircularOut,

		/// <summary>
		/// This value is equivalent to <see cref="CircularIn"/>
		/// </summary>
		[HideInInspector] CircIn = CircularIn,

		/// <summary>
		/// This value is equivalent to <see cref="CircularInOut"/>
		/// </summary>
		[HideInInspector] CircInOut = CircularInOut,

		/// <summary>
		/// This value is equivalent to <see cref="CircularOutIn"/>
		/// </summary>
		[HideInInspector] CircOutIn = CircularOutIn,

		/// <summary>
		/// This value is equivalent to <see cref="QuadraticOut"/>
		/// </summary>
		[HideInInspector] QuadOut = QuadraticOut,

		/// <summary>
		/// This value is equivalent to <see cref="QuadraticIn"/>
		/// </summary>
		[HideInInspector] QuadIn = QuadraticIn,

		/// <summary>
		/// This value is equivalent to <see cref="QuadraticInOut"/>
		/// </summary>
		[HideInInspector] QuadInOut = QuadraticInOut,

		/// <summary>
		/// This value is equivalent to <see cref="QuadraticOutIn"/>
		/// </summary>
		[HideInInspector] QuadOutIn = QuadraticOutIn,

		/// <summary>
		/// This value is equivalent to <see cref="SinusoidalOut"/>
		/// </summary>
		[HideInInspector] SineOut = SinusoidalOut,

		/// <summary>
		/// This value is equivalent to <see cref="SinusoidalIn"/>
		/// </summary>
		[HideInInspector] SineIn = SinusoidalIn,

		/// <summary>
		/// This value is equivalent to <see cref="SinusoidalInOut"/>
		/// </summary>
		[HideInInspector] SineInOut = SinusoidalInOut,

		/// <summary>
		/// This value is equivalent to <see cref="SinusoidalOutIn"/>
		/// </summary>
		[HideInInspector] SineOutIn = SinusoidalOutIn,

		/// <summary>
		/// This value is equivalent to <see cref="QuarticOut"/>
		/// </summary>
		[HideInInspector] QuartOut = QuarticOut,

		/// <summary>
		/// This value is equivalent to <see cref="QuarticIn"/>
		/// </summary>
		[HideInInspector] QuartIn = QuarticIn,

		/// <summary>
		/// This value is equivalent to <see cref="QuarticInOut"/>
		/// </summary>
		[HideInInspector] QuartInOut = QuarticInOut,

		/// <summary>
		/// This value is equivalent to <see cref="QuarticOutIn"/>
		/// </summary>
		[HideInInspector] QuartOutIn = QuarticOutIn,

		/// <summary>
		/// This value is equivalent to <see cref="QuinticOut"/>
		/// </summary>
		[HideInInspector] QuintOut = QuinticOut,

		/// <summary>
		/// This value is equivalent to <see cref="QuinticIn"/>
		/// </summary>
		[HideInInspector] QuintIn = QuinticIn,

		/// <summary>
		/// This value is equivalent to <see cref="QuinticInOut"/>
		/// </summary>
		[HideInInspector] QuintInOut = QuinticInOut,

		/// <summary>
		/// This value is equivalent to <see cref="QuinticOutIn"/>
		/// </summary>
		[HideInInspector] QuintOutIn = QuinticOutIn,
	}
}