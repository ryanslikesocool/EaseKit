// Made with <3 by Ryan Boyer http://ryanjboyer.com

using Unity.Entities;
using UnityEngine;

namespace ifelse.Easings.Entities
{
    [DisallowMultipleComponent]
    [RequiresEntityConversion]
    public class InterpolatorAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        [SerializeField] private EasingType function = EasingType.Linear;
        [SerializeField] private float duration = 2;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new InterpolatorStartTime { Value = Time.time });
            dstManager.AddComponentData(entity, new InterpolatorDuration { Value = duration });
            dstManager.AddComponent<InterpolatorLocalTime>(entity);
            dstManager.AddComponent<InterpolatorPercent>(entity);
            dstManager.AddComponent<InterpolatorValue>(entity);
            dstManager.AddComponent<InterpolatorDone>(entity);

            switch (function)
            {
                default:
                    dstManager.AddComponent<EaseLinear>(entity);
                    break;
                case EasingType.ExpoIn:
                    dstManager.AddComponent<EaseExpoIn>(entity);
                    break;
                case EasingType.ExpoOut:
                    dstManager.AddComponent<EaseExpoOut>(entity);
                    break;
                case EasingType.ExpoInOut:
                    dstManager.AddComponent<EaseExpoInOut>(entity);
                    break;
                case EasingType.ExpoOutIn:
                    dstManager.AddComponent<EaseExpoOutIn>(entity);
                    break;
                case EasingType.CircIn:
                    dstManager.AddComponent<EaseCircIn>(entity);
                    break;
                case EasingType.CircOut:
                    dstManager.AddComponent<EaseCircOut>(entity);
                    break;
                case EasingType.CircInOut:
                    dstManager.AddComponent<EaseCircInOut>(entity);
                    break;
                case EasingType.CircOutIn:
                    dstManager.AddComponent<EaseCircOutIn>(entity);
                    break;
                case EasingType.QuadIn:
                    dstManager.AddComponent<EaseQuadIn>(entity);
                    break;
                case EasingType.QuadOut:
                    dstManager.AddComponent<EaseQuadOut>(entity);
                    break;
                case EasingType.QuadInOut:
                    dstManager.AddComponent<EaseQuadInOut>(entity);
                    break;
                case EasingType.QuadOutIn:
                    dstManager.AddComponent<EaseQuadOutIn>(entity);
                    break;
                case EasingType.SineIn:
                    dstManager.AddComponent<EaseSineIn>(entity);
                    break;
                case EasingType.SineOut:
                    dstManager.AddComponent<EaseSineOut>(entity);
                    break;
                case EasingType.SineInOut:
                    dstManager.AddComponent<EaseSineInOut>(entity);
                    break;
                case EasingType.SineOutIn:
                    dstManager.AddComponent<EaseSineOutIn>(entity);
                    break;
                case EasingType.CubicIn:
                    dstManager.AddComponent<EaseCubicIn>(entity);
                    break;
                case EasingType.CubicOut:
                    dstManager.AddComponent<EaseCubicOut>(entity);
                    break;
                case EasingType.CubicInOut:
                    dstManager.AddComponent<EaseCubicInOut>(entity);
                    break;
                case EasingType.CubicOutIn:
                    dstManager.AddComponent<EaseCubicOutIn>(entity);
                    break;
                case EasingType.QuartIn:
                    dstManager.AddComponent<EaseQuartIn>(entity);
                    break;
                case EasingType.QuartOut:
                    dstManager.AddComponent<EaseQuartOut>(entity);
                    break;
                case EasingType.QuartInOut:
                    dstManager.AddComponent<EaseQuartInOut>(entity);
                    break;
                case EasingType.QuartOutIn:
                    dstManager.AddComponent<EaseQuartOutIn>(entity);
                    break;
                case EasingType.QuintIn:
                    dstManager.AddComponent<EaseQuintIn>(entity);
                    break;
                case EasingType.QuintOut:
                    dstManager.AddComponent<EaseQuintOut>(entity);
                    break;
                case EasingType.QuintInOut:
                    dstManager.AddComponent<EaseQuintInOut>(entity);
                    break;
                case EasingType.QuintOutIn:
                    dstManager.AddComponent<EaseQuintOutIn>(entity);
                    break;
                case EasingType.ElasticIn:
                    dstManager.AddComponent<EaseElasticIn>(entity);
                    break;
                case EasingType.ElasticOut:
                    dstManager.AddComponent<EaseElasticOut>(entity);
                    break;
                case EasingType.ElasticInOut:
                    dstManager.AddComponent<EaseElasticInOut>(entity);
                    break;
                case EasingType.ElasticOutIn:
                    dstManager.AddComponent<EaseElasticOutIn>(entity);
                    break;
                case EasingType.BounceIn:
                    dstManager.AddComponent<EaseBounceIn>(entity);
                    break;
                case EasingType.BounceOut:
                    dstManager.AddComponent<EaseBounceOut>(entity);
                    break;
                case EasingType.BounceInOut:
                    dstManager.AddComponent<EaseBounceInOut>(entity);
                    break;
                case EasingType.BounceOutIn:
                    dstManager.AddComponent<EaseBounceOutIn>(entity);
                    break;
                case EasingType.BackIn:
                    dstManager.AddComponent<EaseBackIn>(entity);
                    break;
                case EasingType.BackOut:
                    dstManager.AddComponent<EaseBackOut>(entity);
                    break;
                case EasingType.BackInOut:
                    dstManager.AddComponent<EaseBackInOut>(entity);
                    break;
                case EasingType.BackOutIn:
                    dstManager.AddComponent<EaseBackOutIn>(entity);
                    break;
            }
        }
    }
}
