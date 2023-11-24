// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct int2Interpolator : IInterpolator<int2> {
		public static readonly int2Interpolator shared = new int2Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int2 Evaluate(in int2 start, in int2 end, float percent)
			=> (int2)math.lerp(start, end, percent);
	}
}
#endif