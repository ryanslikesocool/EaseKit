// Made with <3 by Ryan Boyer http://ryanjboyer.com

using Unity.Entities;
using UnityEngine;

namespace Easings.Entities
{
    [DisallowMultipleComponent]
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
            dstManager.AddEasing(entity, function);
        }
    }
}
