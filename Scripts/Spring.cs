using System;

namespace EaseKit {
    [Serializable]
    public struct Spring {
        public float stiffness; // The spring stiffness coefficient.
        public float damping; // Defines how the spring’s motion should be damped due to the forces of friction.
        public float mass; // The mass of the object attached to the end of the spring.
        public float initialVelocity; // The initial velocity (in units/ms) of the object attached to the spring.

        public bool allowsOverdamping; // Whether or not the spring allows "overdamping" (a damping ratio > 1). Defaults to false.
        public bool overshootClamping; // False when overshooting is allowed, true when it is not. Defaults to false.

        public float restVelocityThreshold; // When spring's velocity is below `restVelocityThreshold`, it is at rest. Defaults to .001.
        public float restDisplacementThreshold; // When the spring's displacement (current value) is below `restDisplacementThreshold`, it is at rest. Defaults to .001.

        public Spring(float mass, float stiffness, float damping, float initialVelocity = 0, bool allowsOverdamping = false, bool overshootClamping = false, float restVelocityThreshold = 0.001f, float restDisplacementThreshold = 0.001f) {
            this.mass = mass;
            this.stiffness = stiffness;
            this.damping = damping;
            this.initialVelocity = initialVelocity;

            this.allowsOverdamping = allowsOverdamping;
            this.overshootClamping = overshootClamping;

            this.restVelocityThreshold = restVelocityThreshold;
            this.restDisplacementThreshold = restDisplacementThreshold;
        }

        internal Solver CreateSolver()
            => new Solver(this);

        public static Spring Default => new Spring(1, 100, 10);

        public override string ToString()
            => $@"
Spring(
    stiffness: {stiffness},
    damping: {damping},
    mass: {mass},
    initialVelocity: {initialVelocity},
    allowsOverdamping: {allowsOverdamping},
    overshootClamping: {overshootClamping},
    restVelocityThreshold: {restVelocityThreshold},
    restDisplacementThreshold: {restDisplacementThreshold}
)
            ";

        // from https://github.com/skevy/wobble/blob/develop/src/index.ts
        public struct Solver {
            private const float FROM_VALUE = 0f;
            private const float TO_VALUE = 1f;
            private const float X0 = TO_VALUE - FROM_VALUE;

            private readonly Spring configuration;

            //private readonly float c;
            //private readonly float m;
            private readonly float k;
            private readonly float v0;

            private readonly float zeta;
            private readonly float omega0; // undamped angular frequency of the oscillator (rad/ms)
            private readonly float omega1; // exponential decay
            private readonly float omega2; // frequency of damped oscillation

            public bool IsComplete { get; private set; }

            public Solver(in Spring configuration) {
                this.configuration = configuration;

                float c = configuration.damping;
                float m = configuration.mass;
                k = configuration.stiffness;
                v0 = -configuration.initialVelocity;

                if (m <= 0) {
                    throw new ArgumentOutOfRangeException("Spring.mass", "Mass value must be greater than 0.");
                }
                if (k <= 0) {
                    throw new ArgumentOutOfRangeException("Spring.stiffness", "Stiffness value must be greater than 0.");
                }

                float zeta = c / (2 * EasingUtility.sqrt(k * m)); // damping ratio (dimensionless)
                float omega0 = EasingUtility.sqrt(k / m); // undamped angular frequency of the oscillator (rad/ms)
                float omega1 = omega0 * EasingUtility.sqrt(1.0f - zeta * zeta); // exponential decay
                float omega2 = omega0 * EasingUtility.sqrt(zeta * zeta - 1.0f); // frequency of damped oscillation

                if (zeta > 1 && !configuration.allowsOverdamping) {
                    zeta = 1;
                }

                if (float.IsNaN(omega0)) {
                    omega0 = 0;
                }
                if (float.IsNaN(omega1)) {
                    omega1 = 0;
                }
                if (float.IsNaN(omega2)) {
                    omega2 = 0;
                }

                this.omega0 = omega0;
                this.omega1 = omega1;
                this.omega2 = omega2;

                this.zeta = zeta;

                IsComplete = false;
            }

            public void Reset() {
                IsComplete = false;
            }

            public float Evaluate(float time, ref State state) {
                if (IsComplete) {
                    return state.currentValue;
                }

                float deltaTime = time - state.currentTime;

                state.springTime += deltaTime;

                float oscillation = 0.0f;
                float velocity = 0.0f;
                float t = state.springTime;
                if (zeta < 1) {
                    // Under damped
                    float envelope = EasingUtility.exp(-zeta * omega0 * t);
                    oscillation = TO_VALUE - envelope * ((v0 + zeta * omega0 * X0) / omega1 * EasingUtility.sin(omega1 * t) + X0 * EasingUtility.cos(omega1 * t));
                    // This looks crazy -- it's actually just the derivative of the
                    // oscillation function
                    velocity = zeta * omega0 * envelope * (EasingUtility.sin(omega1 * t) * (v0 + zeta * omega0 * X0) / omega1 + X0 * EasingUtility.cos(omega1 * t)) - envelope * (EasingUtility.cos(omega1 * t) * (v0 + zeta * omega0 * X0) - omega1 * X0 * EasingUtility.sin(omega1 * t));
                } else if (zeta == 1) {
                    // Critically damped
                    float envelope = EasingUtility.exp(-omega0 * t);
                    oscillation = TO_VALUE - envelope * (X0 + (v0 + omega0 * X0) * t);
                    velocity = envelope * (v0 * (t * omega0 - 1) + t * X0 * (omega0 * omega0));
                } else {
                    // Overdamped
                    float envelope = EasingUtility.exp(-zeta * omega0 * t);
                    oscillation = TO_VALUE - envelope * ((v0 + zeta * omega0 * X0) * EasingUtility.sinh(omega2 * t) + omega2 * X0 * EasingUtility.cosh(omega2 * t)) / omega2;
                    velocity = envelope * zeta * omega0 * (EasingUtility.sinh(omega2 * t) * (v0 + zeta * omega0 * X0) + X0 * omega2 * EasingUtility.cosh(omega2 * t)) / omega2 - envelope * (omega2 * EasingUtility.cosh(omega2 * t) * (v0 + zeta * omega0 * X0) + omega2 * omega2 * X0 * EasingUtility.sinh(omega2 * t)) / omega2;
                }

                state.currentTime = time;
                state.currentValue = oscillation;
                state.currentVelocity = velocity;

                // If the Spring is overshooting (when overshoot clamping is on), or if the
                // spring is at rest (based on the thresholds set in the config), stop the
                // animation.
                if (this.IsSpringOvershooting(state.currentValue) || this.IsSpringAtRest(state.currentValue, state)) {
                    if (k != 0) {
                        // Ensure that we end up with a round value
                        state.currentValue = TO_VALUE;
                        state.currentVelocity = 0;
                    }

                    IsComplete = true;
                }

                return state.currentValue;
            }

            private bool IsSpringOvershooting(float currentValue) {
                bool isOvershooting = false;
                if (configuration.overshootClamping && configuration.stiffness != 0) {
                    // assumes FROM_VALUE < TO_VALUE
                    isOvershooting = currentValue > 1;
                }
                return isOvershooting;
            }

            private bool IsSpringAtRest(float currentValue, in State state) {
                bool isNoVelocity = EasingUtility.abs(state.currentVelocity) <= configuration.restVelocityThreshold;
                bool isNoDisplacement = configuration.stiffness != 0 && EasingUtility.abs(1 - currentValue) <= configuration.restDisplacementThreshold;
                return isNoDisplacement && isNoVelocity;
            }

            public State CreateState()
                => new State(configuration.initialVelocity);

            public override string ToString()
                => $@"
Spring.Solver(
    k: {k},
    v0: {v0},
    zeta: {zeta},
    omega0: {omega0},
    omega1: {omega1},
    omega2: {omega2},
    IsComplete: {IsComplete}
)
                ";

            public struct State {
                public float currentValue;
                public float currentTime;
                public float springTime;
                public float currentVelocity;

                public State(float initialVelocity) {
                    currentValue = Solver.FROM_VALUE;
                    currentTime = 0;
                    springTime = 0;
                    currentVelocity = initialVelocity;
                }

                public override string ToString()
                    => $@"
Spring.Solver.State(
    currentValue: {currentValue},
    currentTime: {currentTime},
    springTime: {springTime},
    currentVelocity: {currentVelocity}
)
                    ";
            }
        }
    }
}