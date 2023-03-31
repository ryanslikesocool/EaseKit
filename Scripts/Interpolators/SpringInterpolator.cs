namespace EaseKit {
    public readonly struct SpringInterpolator<Value> : IInterpolator<Value> {
        private readonly Spring.Solver solver;
        public readonly IInterpolator<Value> subinterpolator;

        public SpringInterpolator(in Spring spring, float initialVelocity, IInterpolator<Value> subinterpolator) {
            this.solver = spring.CreateSolver(initialVelocity);
            this.subinterpolator = subinterpolator;
        }

        public Value Evaluate(Value start, Value end, float percent) {
            float springValue = solver.Evaluate(percent);
            return subinterpolator.Evaluate(start, end, springValue);
        }
    }
}