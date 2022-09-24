// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using Unity.Mathematics;
using UnityEngine;

namespace Easings {
    [CreateAssetMenu(menuName = "Developed With Love/Easings/Custom Easing")]
    public class CustomEasing : ScriptableObject {
        public AnimationCurve curve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));

        [SerializeField] private bool safetyCheck = true;

        public Function function => new Function(new EasingFunctions.EasingFunction(Ease));

        private float Ease(float time, float start, float delta, float duration) {
            float percent = time / duration;
            float sample = curve.Evaluate(percent);
            return math.remap(0, 1, start, start + delta, sample);
        }

        private void OnValidate() {
            if (curve.length < 2) {
                Debug.LogWarning("The animation curve for this custom easing does not have enough anchors (minimum 2).", this);
                return;
            }

            for (int i = 0; i < curve.length; i++) {
                if (curve[i].time < 0.0f || curve[i].time > 1.0f) {
                    Debug.LogWarning($"The time (x) for the anchor at index {i} is out of the range [0.0 ... 1.0] and will be ignored when sampled.", this);
                }
                if (!safetyCheck && (curve[i].value < 0.0f || curve[i].value > 1.0f)) {
                    Debug.LogWarning($"The value (y) for the anchor at index {i} is out of the range [0.0 ... 1.0].  This could cause undesired results when sampling.\nDisable the \"Safety Check\" toggle to hide this warning.", this);
                }
            }

            if (safetyCheck) {
                if (curve[0].time != 0) {
                    Debug.LogWarning("The first anchor of the animation curve does not have the time set to 0.0.  This could cause undesired results when sampling.\nDisable the \"Safety Check\" toggle to hide this warning.", this);
                }
                if (curve[0].value != 0) {
                    Debug.LogWarning("The first anchor of the animation curve does not have the value set to 0.0.  This could cause undesired results when sampling.\nDisable the \"Safety Check\" toggle to hide this warning.", this);
                }
                if (curve[curve.length - 1].time != 1) {
                    Debug.LogWarning("The last anchor of the animation curve does not have the time set to 1.0.  This could cause undesired results when sampling.\nDisable the \"Safety Check\" toggle to hide this warning.", this);
                }
                if (curve[curve.length - 1].value != 1) {
                    Debug.LogWarning("The last anchor of the animation curve does not have the value set to 1.0.  This could cause undesired results when sampling.\nDisable the \"Safety Check\" toggle to hide this warning.", this);
                }
            }
        }
    }
}