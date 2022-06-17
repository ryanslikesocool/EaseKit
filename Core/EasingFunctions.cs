// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using Unity.Mathematics;
using System.Runtime.CompilerServices;

namespace Easings {
    public static class EasingFunctions {
        private const float TAU = math.PI * 2;

        public delegate float EasingFunction(float time, float start, float delta, float duration);

        public static readonly Function LinearEase = new Function(new EasingFunction(Linear.Ease));
        public static readonly Function ExpoOut = new Function(new EasingFunction(Expo.EaseOut));
        public static readonly Function ExpoIn = new Function(new EasingFunction(Expo.EaseIn));
        public static readonly Function ExpoInOut = new Function(new EasingFunction(Expo.EaseInOut));
        public static readonly Function ExpoOutIn = new Function(new EasingFunction(Expo.EaseOutIn));
        public static readonly Function CircOut = new Function(new EasingFunction(Circ.EaseOut));
        public static readonly Function CircIn = new Function(new EasingFunction(Circ.EaseIn));
        public static readonly Function CircInOut = new Function(new EasingFunction(Circ.EaseInOut));
        public static readonly Function CircOutIn = new Function(new EasingFunction(Circ.EaseOutIn));
        public static readonly Function QuadOut = new Function(new EasingFunction(Quad.EaseOut));
        public static readonly Function QuadIn = new Function(new EasingFunction(Quad.EaseIn));
        public static readonly Function QuadInOut = new Function(new EasingFunction(Quad.EaseInOut));
        public static readonly Function QuadOutIn = new Function(new EasingFunction(Quad.EaseOutIn));
        public static readonly Function SineOut = new Function(new EasingFunction(Sine.EaseOut));
        public static readonly Function SineIn = new Function(new EasingFunction(Sine.EaseIn));
        public static readonly Function SineInOut = new Function(new EasingFunction(Sine.EaseInOut));
        public static readonly Function SineOutIn = new Function(new EasingFunction(Sine.EaseOutIn));
        public static readonly Function CubicOut = new Function(new EasingFunction(Cubic.EaseOut));
        public static readonly Function CubicIn = new Function(new EasingFunction(Cubic.EaseIn));
        public static readonly Function CubicInOut = new Function(new EasingFunction(Cubic.EaseInOut));
        public static readonly Function CubicOutIn = new Function(new EasingFunction(Cubic.EaseOutIn));
        public static readonly Function QuartOut = new Function(new EasingFunction(Quart.EaseOut));
        public static readonly Function QuartIn = new Function(new EasingFunction(Quart.EaseIn));
        public static readonly Function QuartInOut = new Function(new EasingFunction(Quart.EaseInOut));
        public static readonly Function QuartOutIn = new Function(new EasingFunction(Quart.EaseOutIn));
        public static readonly Function QuintOut = new Function(new EasingFunction(Quint.EaseOut));
        public static readonly Function QuintIn = new Function(new EasingFunction(Quint.EaseIn));
        public static readonly Function QuintInOut = new Function(new EasingFunction(Quint.EaseInOut));
        public static readonly Function QuintOutIn = new Function(new EasingFunction(Quint.EaseOutIn));
        public static readonly Function ElasticOut = new Function(new EasingFunction(Elastic.EaseOut));
        public static readonly Function ElasticIn = new Function(new EasingFunction(Elastic.EaseIn));
        public static readonly Function ElasticInOut = new Function(new EasingFunction(Elastic.EaseInOut));
        public static readonly Function ElasticOutIn = new Function(new EasingFunction(Elastic.EaseOutIn));
        public static readonly Function BounceOut = new Function(new EasingFunction(Bounce.EaseOut));
        public static readonly Function BounceIn = new Function(new EasingFunction(Bounce.EaseIn));
        public static readonly Function BounceInOut = new Function(new EasingFunction(Bounce.EaseInOut));
        public static readonly Function BounceOutIn = new Function(new EasingFunction(Bounce.EaseOutIn));
        public static readonly Function BackOut = new Function(new EasingFunction(Back.EaseOut));
        public static readonly Function BackIn = new Function(new EasingFunction(Back.EaseIn));
        public static readonly Function BackInOut = new Function(new EasingFunction(Back.EaseInOut));
        public static readonly Function BackOutIn = new Function(new EasingFunction(Back.EaseOutIn));

        public static class Linear {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Ease(float t, float b, float c, float d) => c * t / d + b;
        }

        public static class Expo {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseOut(float t, float b, float c, float d) => (t == d) ? b + c : c * (-math.pow(2, -10 * t / d) + 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => (t == 0) ? b : c * math.pow(2, 10 * (t / d - 1)) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if (t == 0) {
                    return b;
                }
                if (t == d) {
                    return b + c;
                }
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * math.pow(2, 10 * (t - 1)) + b;
                }
                return c * 0.5f * (-math.pow(2, -10 * --t) + 2) + b;
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
            public static float EaseOut(float t, float b, float c, float d) => c * math.sqrt(1 - (t = t / d - 1) * t) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => -c * (math.sqrt(1 - (t /= d) * t) - 1) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return -c * 0.5f * (math.sqrt(1 - t * t) - 1) + b;
                }
                return c * 0.5f * (math.sqrt(1 - (t -= 2) * t) + 1) + b;
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
            public static float EaseOut(float t, float b, float c, float d) => c * math.sin(t / d * (math.PI * 0.5f)) + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) => -c * math.cos(t / d * (math.PI * 0.5f)) + c + b;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) < 1) {
                    return c * 0.5f * (math.sin(math.PI * t * 0.5f)) + b;
                }
                return -c * 0.5f * (math.cos(math.PI * --t * 0.5f) - 2) + b;
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
                return (c * math.pow(2, -10 * t) * math.sin((t * d - s) * TAU / p) + c + b);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseIn(float t, float b, float c, float d) {
                if ((t /= d) == 1) {
                    return b + c;
                }
                float p = d * 0.3f;
                float s = p * 0.5f;
                return -(c * math.pow(2, 10 * (t -= 1)) * math.sin((t * d - s) * TAU / p)) + b;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float EaseInOut(float t, float b, float c, float d) {
                if ((t /= d * 0.5f) == 2) {
                    return b + c;
                }
                float p = d * (.3f * 1.5f);
                float s = p * 0.5f;
                if (t < 1) {
                    return -0.5f * (c * math.pow(2, 10 * (t -= 1)) * math.sin((t * d - s) * TAU / p)) + b;
                }
                return c * math.pow(2, -10 * (t -= 1)) * math.sin((t * d - s) * TAU / p) * 0.5f + c + b;
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