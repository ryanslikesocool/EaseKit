// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	using static EasingUtility;

	public static partial class EasingFunction {
		public static class Circular {
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
	}
}