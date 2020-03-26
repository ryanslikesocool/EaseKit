using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using ifelse.Easings;

[DisallowMultipleComponent]
[RequiresEntityConversion]
public class MoveAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
    public EasingType function;
    public float initial;
    public float target;
    public float duration;
    public bool removeOnDone;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new ifelse.Easings.Entities.Interpolator(initial, target, duration, function, removeOnDone));
    }
}