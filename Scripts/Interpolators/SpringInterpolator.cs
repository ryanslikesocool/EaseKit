namespace EaseKit {
    public struct SpringInterpolator<Value> : IInterpolator<Value> {
        public readonly IInterpolator<Value> subinterpolator;
        private readonly Spring.Solver solver;
        private Spring.Solver.State state;

        public bool IsComplete => state.IsComplete;

        public SpringInterpolator(in Spring spring, float initialVelocity = 0) : this(spring.CreateSolver(), initialVelocity) { }

        public SpringInterpolator(in Spring.Solver solver, float initialVelocity = 0) : this(solver, EasingUtility.CreateInterpolator<Value>(), initialVelocity) { }

        public SpringInterpolator(in IInterpolator<Value> subinterpolator, float initialVelocity = 0) : this(Spring.Default, subinterpolator, initialVelocity) { }

        public SpringInterpolator(in Spring spring, in IInterpolator<Value> subinterpolator, float initialVelocity = 0) : this(spring.CreateSolver(), subinterpolator, initialVelocity) { }

        public SpringInterpolator(in Spring.Solver solver, in IInterpolator<Value> subinterpolator, float initialVelocity = 0) : this(solver, subinterpolator, solver.CreateState(initialVelocity)) { }

        public SpringInterpolator(in Spring.Solver solver, in IInterpolator<Value> subinterpolator, in Spring.Solver.State state) {
            this.subinterpolator = subinterpolator;
            this.solver = solver;
            this.state = state;
        }

        public Value Evaluate(Value start, Value end, float time) {
            float springValue = solver.Evaluate(time, ref state);
            return subinterpolator.Evaluate(start, end, springValue);
        }
    }
}