// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct double2Interpolator : IInterpolator<double2> {
		public static readonly double2Interpolator shared = new double2Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double2 Evaluate(in double2 start, in double2 end, float percent)
			=> math.lerp(start, end, percent);
	}
}
#endif