// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if FOUNDATION_PACKAGE
using System.Runtime.CompilerServices;
using Foundation;

namespace EaseKit {
	public readonly struct ClosedRangeFloatInterpolator : IInterpolator<ClosedRange<float>> {
		public static readonly ClosedRangeFloatInterpolator shared = new ClosedRangeFloatInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ClosedRange<float> Evaluate(in ClosedRange<float> start, in ClosedRange<float> end, float percent) => new ClosedRange<float>(
			EasingUtility.lerp(start.lowerBound, end.lowerBound, percent),
			EasingUtility.lerp(start.upperBound, end.upperBound, percent)
		);
	}
}
#endif