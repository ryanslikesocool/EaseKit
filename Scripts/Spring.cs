using System;

namespace EaseKit {
    [Serializable]
    public struct Spring {
        public float mass;
        public float stiffness;
        public float damping;

        public Spring(float mass, float stiffness, float damping) {
            this.mass = mass;
            this.stiffness = stiffness;
            this.damping = damping;
        }

        public static Spring Default => new Spring(1, 100, 10);

        internal Solver CreateSolver(float initialVelocity) => new Solver(this, initialVelocity);

        // From WebKit https://svn.webkit.org/repository/webkit/trunk/Source/WebCore/platform/graphics/SpringSolver.h
        internal readonly struct Solver {
            private readonly float w0;
            private readonly float zeta;
            private readonly float wd;
            private readonly float A;
            private readonly float B;

            internal Solver(float mass, float stiffness, float damping, float initialVelocity) {
                w0 = EasingUtility.sqrt(stiffness / mass);
                zeta = damping / (2 * EasingUtility.sqrt(stiffness * mass));

                if (zeta < 1) {
                    // Under-damped.
                    wd = w0 * EasingUtility.sqrt(1 - zeta * zeta);
                    A = 1;
                    B = (zeta * w0 + -initialVelocity) / wd;
                } else {
                    // Critically damped (ignoring over-damped case for now).
                    wd = 0;
                    A = 1;
                    B = -initialVelocity + w0;
                }
            }

            internal Solver(in Spring spring, float initialVelocity) : this(spring.mass, spring.stiffness, spring.damping, initialVelocity) { }

            internal float Evaluate(float t) {
                if (zeta < 1) {
                    // Under-damped
                    t = EasingUtility.exp(-t * zeta * w0) * (A * EasingUtility.cos(wd * t) + B * EasingUtility.sin(wd * t));
                } else {
                    // Critically damped (ignoring over-damped case for now).
                    t = (A + B * t) * EasingUtility.exp(-t * w0);
                }

                // Map range from [1..0] to [0..1].
                return 1 - t;
            }
        }
    }
}