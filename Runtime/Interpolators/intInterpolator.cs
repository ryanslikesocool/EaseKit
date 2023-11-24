// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;

namespace EaseKit {
	public readonly struct intInterpolator : IInterpolator<int> {
		public static readonly intInterpolator shared = new intInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Evaluate(in int start, in int end, float percent)
			=> (int)EasingUtility.lerp(start, end, percent);
	}
}
