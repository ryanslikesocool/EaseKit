namespace EaseKit {
	public readonly struct intInterpolator : IInterpolator<int> {
		public static readonly intInterpolator shared = new intInterpolator();

		public int Evaluate(in int start, in int end, float percent)
			=> (int)EasingUtility.lerp(start, end, percent);
	}
}
