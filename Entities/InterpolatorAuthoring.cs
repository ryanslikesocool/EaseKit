// Made with <3 by Ryan Boyer http://ryanjboyer.com

using Unity.Entities;
using UnityEngine;

namespace ifelse.Easings.Entities
{
    [DisallowMultipleComponent]
    [RequiresEntityConversion]
    public class InterpolatorAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        public EasingType function;
        public float initial;
        public float target;
        public float duration;
        public bool removeOnDone;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new Interpolator(initial, target, duration, function, removeOnDone));
        }
    }
}
