// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EaseKit {
	public readonly struct Vector3Interpolator : IInterpolator<Vector3> {
		public static readonly Vector3Interpolator shared = new Vector3Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector3 Evaluate(in Vector3 start, in Vector3 end, float percent)
			=> Vector3.Lerp(start, end, percent);
	}
}