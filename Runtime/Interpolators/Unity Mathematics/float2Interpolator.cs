// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct float2Interpolator : IInterpolator<float2> {
		public static readonly float2Interpolator shared = new float2Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float2 Evaluate(in float2 start, in float2 end, float percent)
			=> math.lerp(start, end, percent);
	}
}
#endif