// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	public static partial class EasingFunction {
		public static class Bounce {
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseOut(float t, float b, float c, float d) {
				if ((t /= d) < (1f / 2.75f)) {
					return c * (7.5625f * t * t) + b;
				} else if (t < (2f / 2.75f)) {
					return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f) + b;
				} else if (t < (2.5f / 2.75f)) {
					return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f) + b;
				} else {
					return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f) + b;
				}
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseIn(float t, float b, float c, float d) => c - EaseOut(d - t, 0, c, d) + b;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseInOut(float t, float b, float c, float d) {
				if (t < d * 0.5f) {
					return EaseIn(t * 2, 0, c, d) * 0.5f + b;
				} else {
					return EaseOut(t * 2 - d, 0, c, d) * 0.5f + c * 0.5f + b;
				}
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