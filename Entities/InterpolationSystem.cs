// Made with <3 by Ryan Boyer http://ryanjboyer.com

using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

namespace ifelse.Easings.Entities
{
    [UpdateInGroup(typeof(SimulationSystemGroup))]
    public class InterpolationSystem : JobComponentSystem
    {
        private BeginInitializationEntityCommandBufferSystem entityCommandBufferSystem;
        private EntityQuery interpolatorQuery;

        protected override void OnCreate()
        {
            entityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
            interpolatorQuery = GetEntityQuery(typeof(Interpolator));
        }

        [BurstCompile]
        struct InterpolateJob : IJobChunk
        {
            public float DeltaTime;
            public ArchetypeChunkComponentType<Interpolator> InterpolatorType;

            public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
            {
                NativeArray<Interpolator> interpolators = chunk.GetNativeArray(InterpolatorType);

                for (int i = 0; i < chunk.Count; i++)
                {
                    Interpolator interpolator = interpolators[i];
                    float delta = interpolator.DeltaTime <= 0 ? DeltaTime : interpolator.DeltaTime;
                    interpolator.Time += delta;

                    float value = 0;

                    if (interpolator.Time > interpolator.Duration)
                    {
                        interpolator.Time = interpolator.Duration;
                        interpolator.Value = interpolator.Target;
                        interpolator.Done = true;
                        interpolator.Percent = 1;
                        interpolators[i] = interpolator;
                        continue;
                    }

                    if (interpolator.Percent < 1)
                    {
                        interpolator.Percent = interpolator.Time / interpolator.Duration;

                        switch (interpolator.Function)
                        {
                            case EasingType.Linear:
                                value = EasingFunctions.Linear.Ease(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoIn:
                                value = EasingFunctions.Expo.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoOut:
                                value = EasingFunctions.Expo.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoOutIn:
                                value = EasingFunctions.Expo.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoInOut:
                                value = EasingFunctions.Expo.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircIn:
                                value = EasingFunctions.Circ.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircOut:
                                value = EasingFunctions.Circ.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircOutIn:
                                value = EasingFunctions.Circ.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircInOut:
                                value = EasingFunctions.Circ.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadIn:
                                value = EasingFunctions.Quad.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadOut:
                                value = EasingFunctions.Quad.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadOutIn:
                                value = EasingFunctions.Quad.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadInOut:
                                value = EasingFunctions.Quad.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineIn:
                                value = EasingFunctions.Sine.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineOut:
                                value = EasingFunctions.Sine.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineOutIn:
                                value = EasingFunctions.Sine.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineInOut:
                                value = EasingFunctions.Sine.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicIn:
                                value = EasingFunctions.Cubic.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicOut:
                                value = EasingFunctions.Cubic.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicOutIn:
                                value = EasingFunctions.Cubic.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicInOut:
                                value = EasingFunctions.Cubic.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartIn:
                                value = EasingFunctions.Quart.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartOut:
                                value = EasingFunctions.Quart.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartOutIn:
                                value = EasingFunctions.Quart.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartInOut:
                                value = EasingFunctions.Quart.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintIn:
                                value = EasingFunctions.Quint.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintOut:
                                value = EasingFunctions.Quint.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintOutIn:
                                value = EasingFunctions.Quint.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintInOut:
                                value = EasingFunctions.Quint.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticIn:
                                value = EasingFunctions.Elastic.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticOut:
                                value = EasingFunctions.Elastic.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticOutIn:
                                value = EasingFunctions.Elastic.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticInOut:
                                value = EasingFunctions.Elastic.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceIn:
                                value = EasingFunctions.Bounce.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceOut:
                                value = EasingFunctions.Bounce.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceOutIn:
                                value = EasingFunctions.Bounce.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceInOut:
                                value = EasingFunctions.Bounce.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackIn:
                                value = EasingFunctions.Back.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackOut:
                                value = EasingFunctions.Back.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackOutIn:
                                value = EasingFunctions.Back.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackInOut:
                                value = EasingFunctions.Back.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                        }
                        interpolator.Value = value;
                    }

                    interpolators[i] = interpolator;
                }
            }
        }

        [BurstCompile]
        struct InterpolatorCompleteJob : IJobChunk
        {
            public EntityCommandBuffer.Concurrent CommandBuffer;
            [ReadOnly] public ArchetypeChunkEntityType EntityType;
            [ReadOnly] public ArchetypeChunkComponentType<Interpolator> InterpolatorType;

            public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
            {
                NativeArray<Interpolator> interpolators = chunk.GetNativeArray(InterpolatorType);
                NativeArray<Entity> entities = chunk.GetNativeArray(EntityType);

                for (int i = 0; i < chunk.Count; i++)
                {
                    Interpolator interpolator = interpolators[i];
                    if (interpolator.Done && interpolator.RemoveOnDone)
                    {
                        CommandBuffer.RemoveComponent<Interpolator>(chunkIndex, entities[i]);
                    }
                }
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDependencies)
        {
            InterpolateJob interpolateJob = new InterpolateJob
            {
                DeltaTime = Time.DeltaTime,
                InterpolatorType = GetArchetypeChunkComponentType<Interpolator>(false)
            };
            inputDependencies = interpolateJob.ScheduleParallel(interpolatorQuery, inputDependencies);

            inputDependencies.Complete();

            InterpolatorCompleteJob interpolatorCompleteJob = new InterpolatorCompleteJob
            {
                CommandBuffer = entityCommandBufferSystem.CreateCommandBuffer().ToConcurrent(),
                EntityType = GetArchetypeChunkEntityType(),
                InterpolatorType = GetArchetypeChunkComponentType<Interpolator>(true),
            };
            inputDependencies = interpolatorCompleteJob.Schedule(interpolatorQuery, inputDependencies);

            inputDependencies.Complete();

            return inputDependencies;
        }
    }
}