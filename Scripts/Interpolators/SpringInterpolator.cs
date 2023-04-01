namespace EaseKit {
    public struct SpringInterpolator<Value> : IInterpolator<Value> {
        public readonly IInterpolator<Value> subinterpolator;
        private readonly Spring.Solver solver;
        private Spring.Solver.State state;

        public bool IsComplete => state.IsComplete;

        public SpringInterpolator(in Spring spring, float initialVelocity = 0) : this(spring, EasingUtility.CreateInterpolator<Value>(), initialVelocity) { }

        public SpringInterpolator(in IInterpolator<Value> subinterpolator, float initialVelocity = 0) : this(Spring.Default, subinterpolator, initialVelocity) { }

        public SpringInterpolator(in Spring spring, in IInterpolator<Value> subinterpolator, float initialVelocity = 0) {
            this.subinterpolator = subinterpolator;
            this.solver = spring.CreateSolver();
            this.state = solver.CreateState(initialVelocity);
        }

        public Value Evaluate(Value start, Value end, float time) {
            float springValue = solver.Evaluate(time, ref state);
            return subinterpolator.Evaluate(start, end, springValue);
        }
    }
}