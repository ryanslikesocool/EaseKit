namespace EaseKit {
    public readonly struct floatInterpolator : IInterpolator<float> {
        public float Evaluate(float start, float end, float percent)
            => EasingUtility.lerp(start, end, percent);
    }
}
