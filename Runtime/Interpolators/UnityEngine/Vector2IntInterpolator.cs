using UnityEngine;

namespace EaseKit {
	public readonly struct Vector2IntInterpolator : IInterpolator<Vector2Int> {
		public static readonly Vector2IntInterpolator shared = new Vector2IntInterpolator();

		public Vector2Int Evaluate(in Vector2Int start, in Vector2Int end, float percent)
			=> new Vector2Int(
				intInterpolator.shared.Evaluate(start.x, end.x, percent),
				intInterpolator.shared.Evaluate(start.y, end.y, percent)
			);
	}
}