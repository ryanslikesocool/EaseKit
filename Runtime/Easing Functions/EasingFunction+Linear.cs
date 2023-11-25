// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	public static partial class EasingFunction {
		public static class Linear {
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ease(float t, float b, float c, float d) => c * t / d + b;
		}
	}
}