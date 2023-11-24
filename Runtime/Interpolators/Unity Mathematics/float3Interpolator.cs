// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct float3Interpolator : IInterpolator<float3> {
		public static readonly float3Interpolator shared = new float3Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float3 Evaluate(in float3 start, in float3 end, float percent)
			=> math.lerp(start, end, percent);
	}
}
#endif