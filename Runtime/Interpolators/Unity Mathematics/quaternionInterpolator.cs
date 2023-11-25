// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct quaternionInterpolator : IInterpolator<quaternion> {
		public static readonly quaternionInterpolator shared = new quaternionInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public quaternion Evaluate(in quaternion start, in quaternion end, float percent)
			=> math.slerp(start, end, percent);
	}
}
#endif