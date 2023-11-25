// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System;

namespace EaseKit {
	/// <summary>
	/// The description of a spring.
	/// </summary>
	[Serializable]
	public struct Spring {
		public float stiffness; // The spring stiffness coefficient.
		public float damping; // Defines how the spring’s motion should be damped due to the forces of friction.
		public float mass; // The mass of the object attached to the end of the spring.

		public bool allowsOverdamping; // Whether or not the spring allows "overdamping" (a damping ratio > 1). Defaults to false.
		public bool overshootClamping; // False when overshooting is allowed, true when it is not. Defaults to false.

		public float restVelocityThreshold; // When spring's velocity is below `restVelocityThreshold`, it is at rest. Defaults to .001.
		public float restDisplacementThreshold; // When the spring's displacement (current value) is below `restDisplacementThreshold`, it is at rest. Defaults to .001.

		public Spring(float mass, float stiffness, float damping, bool allowsOverdamping = false, bool overshootClamping = false, float restVelocityThreshold = 0.001f, float restDisplacementThreshold = 0.001f) {
			this.mass = mass;
			this.stiffness = stiffness;
			this.damping = damping;

			this.allowsOverdamping = allowsOverdamping;
			this.overshootClamping = overshootClamping;

			this.restVelocityThreshold = restVelocityThreshold;
			this.restDisplacementThreshold = restDisplacementThreshold;
		}

		public Solver CreateSolver()
			=> new Solver(this);

		public static Spring Default => new Spring(1, 100, 10);

		public override string ToString()
			=> $@"
Spring(
    stiffness: {stiffness},
    damping: {damping},
    mass: {mass},
    allowsOverdamping: {allowsOverdamping},
    overshootClamping: {overshootClamping},
    restVelocityThreshold: {restVelocityThreshold},
    restDisplacementThreshold: {restDisplacementThreshold}
)
            ";

		/// <summary>
		/// A <see cref="Spring"/> solver.
		/// </summary>
		/// <remarks>
		/// Solvers should be cached the first time they are needed, since they can be expensive to create every frame.
		/// <remarks/>
		/// <seealso cref="Spring"/>
		// from https://github.com/skevy/wobble/blob/develop/src/index.ts
		public readonly struct Solver {
			private readonly Spring configuration;

			private readonly float zeta;
			private readonly float omega0; // undamped angular frequency of the oscillator (rad/ms)
			private readonly float omega1; // exponential decay
			private readonly float omega2; // frequency of damped oscillation

			/// <summary>
			/// Create a Solver from a <see cref="Spring"/> description.
			/// </summary>
			/// <remarks>
			/// The Solver should be cached for use in animation, since it can be expensive to create every frame.
			/// </remarks>
			/// <param name="configuration">The spring description.</param>
			/// <seealso cref="Spring"/>
			public Solver(in Spring configuration) {
				this.configuration = configuration;

				float c = configuration.damping;
				float m = configuration.mass;
				float k = configuration.stiffness;

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
			}

			internal Solver(in Spring configuration, float zeta, float omega0, float omega1, float omega2) {
				this.configuration = configuration;
				this.zeta = zeta;
				this.omega0 = omega0;
				this.omega1 = omega1;
				this.omega2 = omega2;
			}

			/// <summary>
			/// Evaluate the spring from a local time and existing spring state.
			/// </summary>
			/// <param name="time">The time since the spring was started.</param>
			/// <param name="state">The spring state.</param>
			/// <returns>A parametric value.  This can be used as the <c>t</c> value in an unclamped interpolation function.</returns>
			public float Evaluate(float time, ref State state) {
				if (state.IsComplete) {
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
					oscillation = 1 - envelope * ((-state.initialVelocity + zeta * omega0) / omega1 * EasingUtility.sin(omega1 * t) + EasingUtility.cos(omega1 * t));
					// This looks crazy -- it's actually just the derivative of the
					// oscillation function
					velocity = zeta * omega0 * envelope * (EasingUtility.sin(omega1 * t) * (-state.initialVelocity + zeta * omega0) / omega1 + EasingUtility.cos(omega1 * t)) - envelope * (EasingUtility.cos(omega1 * t) * (-state.initialVelocity + zeta * omega0) - omega1 * EasingUtility.sin(omega1 * t));
				} else if (zeta == 1) {
					// Critically damped
					float envelope = EasingUtility.exp(-omega0 * t);
					oscillation = 1 - envelope * (1 + (-state.initialVelocity + omega0) * t);
					velocity = envelope * (-state.initialVelocity * (t * omega0 - 1) + t * (omega0 * omega0));
				} else {
					// Overdamped
					float envelope = EasingUtility.exp(-zeta * omega0 * t);
					oscillation = 1 - envelope * ((-state.initialVelocity + zeta * omega0) * EasingUtility.sinh(omega2 * t) + omega2 * EasingUtility.cosh(omega2 * t)) / omega2;
					velocity = envelope * zeta * omega0 * (EasingUtility.sinh(omega2 * t) * (-state.initialVelocity + zeta * omega0) + omega2 * EasingUtility.cosh(omega2 * t)) / omega2 - envelope * (omega2 * EasingUtility.cosh(omega2 * t) * (-state.initialVelocity + zeta * omega0) + omega2 * omega2 * EasingUtility.sinh(omega2 * t)) / omega2;
				}

				state.currentTime = time;
				state.currentValue = oscillation;
				state.currentVelocity = velocity;

				// If the Spring is overshooting (when overshoot clamping is on), or if the
				// spring is at rest (based on the thresholds set in the config), stop the
				// animation.
				if (this.IsSpringOvershooting(state.currentValue) || this.IsSpringAtRest(state.currentValue, state)) {
					if (configuration.stiffness != 0) {
						// Ensure that we end up with a round value
						state.currentValue = 1;
						state.currentVelocity = 0;
					}

					state.IsComplete = true;
				}

				return state.currentValue;
			}

			private bool IsSpringOvershooting(float currentValue) {
				bool isOvershooting = false;
				if (configuration.overshootClamping && configuration.stiffness != 0) {
					isOvershooting = currentValue > 1;
				}
				return isOvershooting;
			}

			private bool IsSpringAtRest(float currentValue, in State state) {
				bool isNoVelocity = EasingUtility.abs(state.currentVelocity) <= configuration.restVelocityThreshold;
				bool isNoDisplacement = configuration.stiffness != 0 && EasingUtility.abs(1 - currentValue) <= configuration.restDisplacementThreshold;
				return isNoDisplacement && isNoVelocity;
			}

			/// <summary>
			/// Create an initial spring state with an initial velocity.
			/// </summary>
			/// <param name="initialVelocity">The initial velocity of the spring.  This is useful for smoother movement when interrupting or continuing animations.</param>
			/// <returns>A new spring state for use in a solver.</returns>
			public State CreateState(float initialVelocity)
				=> new State(initialVelocity);

			public static Solver Default => new Solver(
				configuration: Spring.Default,
				zeta: 0.5f,
				omega0: 10f,
				omega1: 8.660254f,
				omega2: 0f
			);

			public override string ToString()
				=> $@"
Spring.Solver(
    zeta: {zeta},
    omega0: {omega0},
    omega1: {omega1},
    omega2: {omega2}
)
                ";

			/// <summary>
			/// A spring state.  This contains essential information about the current state of an animating spring, and should be cached for reuse with a solver.
			/// </summary>
			public struct State {
				public readonly float initialVelocity;
				public float currentValue;
				public float currentTime;
				public float springTime;
				public float currentVelocity;
				public bool IsComplete { get; internal set; }

				public State(float initialVelocity) {
					this.initialVelocity = initialVelocity;
					currentValue = 0;
					currentTime = 0;
					springTime = 0;
					currentVelocity = initialVelocity;
					IsComplete = false;
				}

				public static State Default => new State(0);

				public override string ToString()
					=> $@"
Spring.Solver.State(
    initialVelocity: {initialVelocity},
    currentValue: {currentValue},
    currentTime: {currentTime},
    springTime: {springTime},
    currentVelocity: {currentVelocity},
    IsComplete: {IsComplete}
)
                    ";
			}
		}
	}
}