// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EaseKit {
	public readonly struct QuaternionInterpolator : IInterpolator<Quaternion> {
		public static readonly QuaternionInterpolator shared = new QuaternionInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Quaternion Evaluate(in Quaternion start, in Quaternion end, float percent)
			=> Quaternion.Slerp(start, end, percent);
	}
}