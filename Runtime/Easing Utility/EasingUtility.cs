// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using UnityEngine;
using System;
#if UNITY_MATHEMATICS
using Unity.Mathematics;
#endif
#if FOUNDATION_PACKAGE
using Foundation;
#endif

namespace EaseKit {
	public static partial class EasingUtility {
		public delegate float Function(float time, float start, float delta, float duration);

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
		/// <returns>The interpolator for the provided type.  This struct can be safely reused.</returns>
		public static IInterpolator<Value> CreateInterpolator<Value>() => default(Value) switch {
			int => intInterpolator.shared as IInterpolator<Value>,
			float => floatInterpolator.shared as IInterpolator<Value>,
			Vector2 => Vector2Interpolator.shared as IInterpolator<Value>,
			Vector3 => Vector3Interpolator.shared as IInterpolator<Value>,
			Vector4 => Vector4Interpolator.shared as IInterpolator<Value>,
			Vector2Int => Vector2IntInterpolator.shared as IInterpolator<Value>,
			Vector3Int => Vector3IntInterpolator.shared as IInterpolator<Value>,
			Quaternion => QuaternionInterpolator.shared as IInterpolator<Value>,
			Color => ColorInterpolator.shared as IInterpolator<Value>,
#if UNITY_MATHEMATICS
			int2 => int2Interpolator.shared as IInterpolator<Value>,
			int3 => int3Interpolator.shared as IInterpolator<Value>,
			int4 => int4Interpolator.shared as IInterpolator<Value>,
			float2 => float2Interpolator.shared as IInterpolator<Value>,
			float3 => float3Interpolator.shared as IInterpolator<Value>,
			float4 => float4Interpolator.shared as IInterpolator<Value>,
			double => doubleInterpolator.shared as IInterpolator<Value>,
			double2 => double2Interpolator.shared as IInterpolator<Value>,
			double3 => double3Interpolator.shared as IInterpolator<Value>,
			double4 => double4Interpolator.shared as IInterpolator<Value>,
			quaternion => quaternionInterpolator.shared as IInterpolator<Value>,
#endif
#if FOUNDATION_PACKAGE
			ClosedRange<float> => ClosedRangeFloatInterpolator.shared as IInterpolator<Value>,
#endif
			_ => throw new Exception($"Type {typeof(Value)} does not have an interpolator implementation.")
		};

		// MARK: - Quick Access

		public static readonly Function LinearEase = EasingFunction.Linear.Ease;
		public static readonly Function ExpoOut = EasingFunction.Exponential.EaseOut;
		public static readonly Function ExpoIn = EasingFunction.Exponential.EaseIn;
		public static readonly Function ExpoInOut = EasingFunction.Exponential.EaseInOut;
		public static readonly Function ExpoOutIn = EasingFunction.Exponential.EaseOutIn;
		public static readonly Function CircOut = EasingFunction.Circular.EaseOut;
		public static readonly Function CircIn = EasingFunction.Circular.EaseIn;
		public static readonly Function CircInOut = EasingFunction.Circular.EaseInOut;
		public static readonly Function CircOutIn = EasingFunction.Circular.EaseOutIn;
		public static readonly Function QuadOut = EasingFunction.Quadratic.EaseOut;
		public static readonly Function QuadIn = EasingFunction.Quadratic.EaseIn;
		public static readonly Function QuadInOut = EasingFunction.Quadratic.EaseInOut;
		public static readonly Function QuadOutIn = EasingFunction.Quadratic.EaseOutIn;
		public static readonly Function SineOut = EasingFunction.Sinusoidal.EaseOut;
		public static readonly Function SineIn = EasingFunction.Sinusoidal.EaseIn;
		public static readonly Function SineInOut = EasingFunction.Sinusoidal.EaseInOut;
		public static readonly Function SineOutIn = EasingFunction.Sinusoidal.EaseOutIn;
		public static readonly Function CubicOut = EasingFunction.Cubic.EaseOut;
		public static readonly Function CubicIn = EasingFunction.Cubic.EaseIn;
		public static readonly Function CubicInOut = EasingFunction.Cubic.EaseInOut;
		public static readonly Function CubicOutIn = EasingFunction.Cubic.EaseOutIn;
		public static readonly Function QuartOut = EasingFunction.Quartic.EaseOut;
		public static readonly Function QuartIn = EasingFunction.Quartic.EaseIn;
		public static readonly Function QuartInOut = EasingFunction.Quartic.EaseInOut;
		public static readonly Function QuartOutIn = EasingFunction.Quartic.EaseOutIn;
		public static readonly Function QuintOut = EasingFunction.Quintic.EaseOut;
		public static readonly Function QuintIn = EasingFunction.Quintic.EaseIn;
		public static readonly Function QuintInOut = EasingFunction.Quintic.EaseInOut;
		public static readonly Function QuintOutIn = EasingFunction.Quintic.EaseOutIn;
		public static readonly Function ElasticOut = EasingFunction.Elastic.EaseOut;
		public static readonly Function ElasticIn = EasingFunction.Elastic.EaseIn;
		public static readonly Function ElasticInOut = EasingFunction.Elastic.EaseInOut;
		public static readonly Function ElasticOutIn = EasingFunction.Elastic.EaseOutIn;
		public static readonly Function BounceOut = EasingFunction.Bounce.EaseOut;
		public static readonly Function BounceIn = EasingFunction.Bounce.EaseIn;
		public static readonly Function BounceInOut = EasingFunction.Bounce.EaseInOut;
		public static readonly Function BounceOutIn = EasingFunction.Bounce.EaseOutIn;
		public static readonly Function BackOut = EasingFunction.Back.EaseOut;
		public static readonly Function BackIn = EasingFunction.Back.EaseIn;
		public static readonly Function BackInOut = EasingFunction.Back.EaseInOut;
		public static readonly Function BackOutIn = EasingFunction.Back.EaseOutIn;
	}
}