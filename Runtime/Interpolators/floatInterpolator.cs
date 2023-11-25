// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	public readonly struct floatInterpolator : IInterpolator<float> {
		public static readonly floatInterpolator shared = new floatInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float Evaluate(in float start, in float end, float percent)
			=> EasingUtility.lerp(start, end, percent);
	}
}
