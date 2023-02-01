using UnityEngine;
#if UNITY_MATHEMATICS
using Unity.Mathematics;
#endif

namespace EaseKit {
    public struct AnimationCurveInterpolator : IInterpolator<float> {
        public readonly AnimationCurve animationCurve;

        public AnimationCurveInterpolator(AnimationCurve animationCurve) {
            this.animationCurve = animationCurve;
        }

        public float Evaluate(float start, float end, float percent) {
            float animationCurveValue = animationCurve.Evaluate(percent);
#if UNITY_MATHEMATICS
            return math.lerp(start, end, animationCurveValue);
#else
            return Mathf.Lerp(start, end, animationCurveValue);
#endif
        }
    }
}