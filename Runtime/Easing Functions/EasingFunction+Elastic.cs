// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	using static EasingUtility;

	public static partial class EasingFunction {
		public static class Elastic {
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseOut(float t, float b, float c, float d) {
				if ((t /= d) == 1) {
					return b + c;
				}
				float p = d * 0.3f;
				float s = p * 0.5f;
				return (c * pow(2, -10 * t) * sin((t * d - s) * TAU / p) + c + b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseIn(float t, float b, float c, float d) {
				if ((t /= d) == 1) {
					return b + c;
				}
				float p = d * 0.3f;
				float s = p * 0.5f;
				return -(c * pow(2, 10 * (t -= 1)) * sin((t * d - s) * TAU / p)) + b;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float EaseInOut(float t, float b, float c, float d) {
				if ((t /= d * 0.5f) == 2) {
					return b + c;
				}
				float p = d * (.3f * 1.5f);
				float s = p * 0.5f;
				if (t < 1) {
					return -0.5f * (c * pow(2, 10 * (t -= 1)) * sin((t * d - s) * TAU / p)) + b;
				}
				return c * pow(2, -10 * (t -= 1)) * sin((t * d - s) * TAU / p) * 0.5f + c + b;
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