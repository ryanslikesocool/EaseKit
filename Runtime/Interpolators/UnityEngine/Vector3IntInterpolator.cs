// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EaseKit {
	public readonly struct Vector3IntInterpolator : IInterpolator<Vector3Int> {
		public static readonly Vector3IntInterpolator shared = new Vector3IntInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector3Int Evaluate(in Vector3Int start, in Vector3Int end, float percent)
			=> new Vector3Int(
				intInterpolator.shared.Evaluate(start.x, end.x, percent),
				intInterpolator.shared.Evaluate(start.y, end.y, percent),
				intInterpolator.shared.Evaluate(start.z, end.z, percent)
			);
	}
}