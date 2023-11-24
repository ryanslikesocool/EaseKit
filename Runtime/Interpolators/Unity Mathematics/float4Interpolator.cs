// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct float4Interpolator : IInterpolator<float4> {
		public static readonly float4Interpolator shared = new float4Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4 Evaluate(in float4 start, in float4 end, float percent)
			=> math.lerp(start, end, percent);
	}
}
#endif