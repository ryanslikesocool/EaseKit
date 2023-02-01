// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
#if UNITY_MATHEMATICS
using Unity.Mathematics;
#endif

namespace EaseKit {
    public static class Functions {
        private delegate float f_f_delegate(float v);
        private delegate float ff_f_delegate(float v, float n);
#if UNITY_MATHEMATICS
        private const float PI = math.PI;
        private const float TAU = PI * 2;
        private static readonly f_f_delegate sqrt = math.sqrt;
        private static readonly ff_f_delegate pow = math.pow;
        private static readonly f_f_delegate sin = math.sin;
        private static readonly f_f_delegate cos = math.cos;

#else
        private const float PI = Mathf.Pi;
        private const float TAU = PI * 2;
        private static readonly f_f_delegate sqrt = Mathf.Sqrt;
        private static readonly ff_f_delegate pow = Mathf.Pow;
        private static readonly f_f_delegate sin = Mathf.Sin;
        private static readonly f_f_delegate cos = Mathf.Cos;
#endif

        public delegate float Function(float time, float start, float delta, float duration);

        public static readonly Function LinearEase = Linear.Ease;
        public static readonly Function ExpoOut = Expo.EaseOut;
        public static readonly Function ExpoIn = Expo.EaseIn;
        public static readonly Function ExpoInOut = Expo.EaseInOut;
        public static readonly Function ExpoOutIn = Expo.EaseOutIn;
        public static readonly Function CircOut = Circ.EaseOut;
        public static readonly Function CircIn = Circ.EaseIn;
        public static readonly Function CircInOut = Circ.EaseInOut;
        public static readonly Function CircOutIn = Circ.EaseOutIn;
        public static readonly Function QuadOut = Quad.EaseOut;
        public static readonly Function QuadIn = Quad.EaseIn;
        public static readonly Function QuadInOut = Quad.EaseInOut;
        public static readonly Function QuadOutIn = Quad.EaseOutIn;
        public static readonly Function SineOut = Sine.EaseOut;
        public static readonly Function SineIn = Sine.EaseIn;
        public static readonly Function SineInOut = Sine.EaseInOut;
        public static readonly Function SineOutIn = Sine.EaseOutIn;
        public static readonly Function CubicOut = Cubic.EaseOut;
        public static readonly Function CubicIn = Cubic.EaseIn;
        public static readonly Function CubicInOut = Cubic.EaseInOut;
        public static readonly Function CubicOutIn = Cubic.EaseOutIn;
        public static readonly Function QuartOut = Quart.EaseOut;
        public static readonly Function QuartIn = Quart.EaseIn;
        public static readonly Function QuartInOut = Quart.EaseInOut;
        public static readonly Function QuartOutIn = Quart.EaseOutIn;
        public static readonly Function QuintOut = Quint.EaseOut;
        public static readonly Function QuintIn = Quint.EaseIn;
        public static readonly Function QuintInOut = Quint.EaseInOut;
        public static readonly Function QuintOutIn = Quint.EaseOutIn;
        public static readonly Function ElasticOut = Elastic.EaseOut;
        public static readonly Function ElasticIn = Elastic.EaseIn;
        public static readonly Function ElasticInOut = Elastic.EaseInOut;
        public static readonly Function ElasticOutIn = Elastic.EaseOutIn;
        public static readonly Function BounceOut = Bounce.EaseOut;
        public static readonly Function BounceIn = Bounce.EaseIn;
        public static readonly Function BounceInOut = Bounce.EaseInOut;
        public static readonly Function BounceOutIn = Bounce.EaseOutIn;
        public static readonly Function BackOut = Back.EaseOut;
        public static readonly Function BackIn = Back.EaseIn;
        public static readonly Function BackInOut = Back.EaseInOut;
        public static readonly Function BackOutIn = Back.EaseOutIn;

        public static class Linear {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Ease(float t, float b, float c, float d) => c * t / d + b;
        }

        public static class Expo {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => (t == d) ? b + c : c * (-pow(2, -10 * t / d) + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => (t == 0) ? b : c * pow(2, 10 * (t / d - 1)) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if (t == 0) {
                    return b;
                }
                if (t == d) {
                    return b + c;
                }
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * pow(2, 10 * (t - 1)) + b;
                }
                return c * 0.5f * (-pow(2, -10 * --t) + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Circ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * sqrt(1 - (t = t / d - 1) * t) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => -c * (sqrt(1 - (t /= d) * t) - 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return -c * 0.5f * (sqrt(1 - t * t) - 1) + b;
                }
                return c * 0.5f * (sqrt(1 - (t -= 2) * t) + 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Quad {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => -c * (t /= d) * (t - 2) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t + b;
                }
                return -c * 0.5f * ((--t) * (t - 2) - 1) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Sine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * sin(t / d * (PI * 0.5f)) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => -c * cos(t / d * (PI * 0.5f)) + c + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * (sin(PI * t * 0.5f)) + b;
                }
                return -c * 0.5f * (cos(PI * --t * 0.5f) - 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Cubic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * ((t = t / d - 1) * t * t + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t * t + b;
                }
                return c * 0.5f * ((t -= 2) * t * t + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Quart {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => -c * ((t = t / d - 1) * t * t * t - 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * t * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t * t * t + b;
                }
                return -c * 0.5f * ((t -= 2) * t * t * t - 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Quint {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * ((t = t / d - 1) * t * t * t * t + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * t * t * t + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * t * t * t * t * t + b;
                }
                return c * 0.5f * ((t -= 2) * t * t * t * t + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Elastic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) {
                if ((t /= d) == 1) {
                    return b + c;
                }
                float p = d * 0.3f;
                float s = p * 0.5f;
                return (c * pow(2, -10 * t) * sin((t * d - s) * TAU / p) + c + b);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) {
                if ((t /= d) == 1) {
                    return b + c;
                }
                float p = d * 0.3f;
                float s = p * 0.5f;
                return -(c * pow(2, 10 * (t -= 1)) * sin((t * d - s) * TAU / p)) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) == 2) {
                    return b + c;
                }
                float p = d * (.3f * 1.5f);
                float s = p * 0.5f;
                if (t < 1) {
                    return -0.5f * (c * pow(2, 10 * (t -= 1)) * sin((t * d - s) * TAU / p)) + b;
                }
                return c * pow(2, -10 * (t -= 1)) * sin((t * d - s) * TAU / p) * 0.5f + c + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Bounce {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) {
                if ((t /= d) < (1f / 2.75f)) {
                    return c * (7.5625f * t * t) + b;
                } else if (t < (2f / 2.75f)) {
                    return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f) + b;
                } else if (t < (2.5f / 2.75f)) {
                    return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f) + b;
                } else {
                    return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f) + b;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c - EaseOut(d - t, 0, c, d) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseIn(t * 2, 0, c, d) * 0.5f + b;
                } else {
                    return EaseOut(t * 2 - d, 0, c, d) * 0.5f + c * 0.5f + b;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }

        public static class Back {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => c * ((t = t / d - 1) * t * ((1.70158f + 1) * t + 1.70158f) + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => c * (t /= d) * t * ((1.70158f + 1) * t - 1.70158f) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                float s = 1.70158f;
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * (t * t * (((s *= (1.525f)) + 1) * t - s)) + b;
                }
                return c * 0.5f * ((t -= 2) * t * (((s *= (1.525f)) + 1) * t + s) + 2) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOutIn(float t, float b, float c, float d) {
                if (t < d * 0.5f) {
                    return EaseOut(t * 2, b, c * 0.5f, d);
                }
                return EaseIn((t * 2) - d, b + c * 0.5f, c * 0.5f, d);
            }
        }
    }
}