// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	public static partial class EasingFunction {
		public static class Quartic {
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
	}
}