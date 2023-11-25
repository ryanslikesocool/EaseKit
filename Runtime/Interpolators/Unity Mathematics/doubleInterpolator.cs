// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#if UNITY_MATHEMATICS
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace EaseKit {
	public readonly struct doubleInterpolator : IInterpolator<double> {
		public static readonly doubleInterpolator shared = new doubleInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double Evaluate(in double start, in double end, float percent)
			=> math.lerp(start, end, percent);
	}
}
#endif
