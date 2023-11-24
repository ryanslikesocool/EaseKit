#if UNITY_MATHEMATICS
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct int4Interpolator : IInterpolator<int4> {
		public static readonly int4Interpolator shared = new int4Interpolator();

		public int4 Evaluate(in int4 start, in int4 end, float percent)
			=> (int4)math.lerp(start, end, percent);
	}
}
#endif