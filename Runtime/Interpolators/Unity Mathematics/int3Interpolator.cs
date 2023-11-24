// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct int3Interpolator : IInterpolator<int3> {
		public static readonly int3Interpolator shared = new int3Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int3 Evaluate(in int3 start, in int3 end, float percent)
			=> (int3)math.lerp(start, end, percent);
	}
}
#endif