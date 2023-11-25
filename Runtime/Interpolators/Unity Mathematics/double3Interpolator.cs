// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct double3Interpolator : IInterpolator<double3> {
		public static readonly double3Interpolator shared = new double3Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double3 Evaluate(in double3 start, in double3 end, float percent)
			=> math.lerp(start, end, percent);
	}
}
#endif