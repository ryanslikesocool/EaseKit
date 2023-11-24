// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct double4Interpolator : IInterpolator<double4> {
		public static readonly double4Interpolator shared = new double4Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double4 Evaluate(in double4 start, in double4 end, float percent)
			=> math.lerp(start, end, percent);
	}
}
#endif