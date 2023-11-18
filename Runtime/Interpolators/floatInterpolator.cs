namespace EaseKit {
    public readonly struct floatInterpolator : IInterpolator<float> {
        public static readonly floatInterpolator shared = new floatInterpolator();

        public float Evaluate(in float start, in float end, float percent)
            => EasingUtility.lerp(start, end, percent);
    }
}
