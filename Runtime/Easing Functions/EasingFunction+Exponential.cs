// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	using static EasingUtility;

	public static partial class EasingFunction {
		public static class Exponential {
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseOut(float t, float b, float c, float d) => (t == d) ? b + c : c * (-pow(2, -10 * t / d) + 1) + b;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseIn(float t, float b, float c, float d) => (t == 0) ? b : c * pow(2, 10 * (t / d - 1)) + b;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseInOut(float t, float b, float c, float d) {
				if (t == 0) {
					return b;
				}
				if (t == d) {
					return b + c;
				}
				if ((t /= d * 0.5f) < 1) {
					return c * 0.5f * pow(2, 10 * (t - 1)) + b;
				}
				return c * 0.5f * (-pow(2, -10 * --t) + 2) + b;
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