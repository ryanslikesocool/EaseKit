// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct int4Interpolator : IInterpolator<int4> {
		public static readonly int4Interpolator shared = new int4Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int4 Evaluate(in int4 start, in int4 end, float percent)
			=> (int4)math.lerp(start, end, percent);
	}
}
#endif