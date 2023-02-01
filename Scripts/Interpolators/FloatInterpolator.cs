#if UNITY_MATHEMATICS
using Unity.Mathematics;
#else
using UnityEngine;
#endif

namespace EaseKit {
    public struct FloatInterpolator : IInterpolator<float> {
        public float Evaluate(float start, float end, float percent)
#if UNITY_MATHEMATICS
            => math.lerp(start, end, percent);
#else
            => Mathf.Lerp(start, end, percent);
#endif
    }
}
