#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct int2Interpolator : IInterpolator<int2> {
		public static readonly int2Interpolator shared = new int2Interpolator();

		public int2 Evaluate(in int2 start, in int2 end, float percent)
			=> (int2)math.lerp(start, end, percent);
	}
}
#endif