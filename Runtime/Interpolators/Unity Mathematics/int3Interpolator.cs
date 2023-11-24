#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct int3Interpolator : IInterpolator<int3> {
		public static readonly int3Interpolator shared = new int3Interpolator();

		public int3 Evaluate(in int3 start, in int3 end, float percent)
			=> (int3)math.lerp(start, end, percent);
	}
}
#endif