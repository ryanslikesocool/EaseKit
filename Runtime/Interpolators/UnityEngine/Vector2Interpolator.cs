// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EaseKit {
	public readonly struct Vector2Interpolator : IInterpolator<Vector2> {
		public static readonly Vector2Interpolator shared = new Vector2Interpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector2 Evaluate(in Vector2 start, in Vector2 end, float percent)
			=> Vector2.Lerp(start, end, percent);
	}
}