namespace EaseKit {
    public struct SpringInterpolator<Value> : IInterpolator<Value> {
        public readonly IInterpolator<Value> subinterpolator;
        private readonly Spring.Solver solver;
        private Spring.Solver.State state;

        public bool IsComplete => solver.IsComplete;

        public SpringInterpolator(in Spring spring) : this(spring, EasingUtility.CreateInterpolator<Value>()) { }

        public SpringInterpolator(IInterpolator<Value> subinterpolator) : this(Spring.Default, subinterpolator) { }

        public SpringInterpolator(in Spring spring, IInterpolator<Value> subinterpolator) {
            this.subinterpolator = subinterpolator;
            this.solver = spring.CreateSolver();
            this.state = solver.CreateState();
        }

        public Value Evaluate(Value start, Value end, float time) {
            float springValue = solver.Evaluate(time, ref state);
            return subinterpolator.Evaluate(start, end, springValue);
        }
    }
}