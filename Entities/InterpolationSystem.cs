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
                                value = EasingFunctionsInline.Linear.Ease(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoIn:
                                value = EasingFunctionsInline.Expo.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoOut:
                                value = EasingFunctionsInline.Expo.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoOutIn:
                                value = EasingFunctionsInline.Expo.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ExpoInOut:
                                value = EasingFunctionsInline.Expo.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircIn:
                                value = EasingFunctionsInline.Circ.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircOut:
                                value = EasingFunctionsInline.Circ.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircOutIn:
                                value = EasingFunctionsInline.Circ.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CircInOut:
                                value = EasingFunctionsInline.Circ.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadIn:
                                value = EasingFunctionsInline.Quad.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadOut:
                                value = EasingFunctionsInline.Quad.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadOutIn:
                                value = EasingFunctionsInline.Quad.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuadInOut:
                                value = EasingFunctionsInline.Quad.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineIn:
                                value = EasingFunctionsInline.Sine.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineOut:
                                value = EasingFunctionsInline.Sine.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineOutIn:
                                value = EasingFunctionsInline.Sine.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.SineInOut:
                                value = EasingFunctionsInline.Sine.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicIn:
                                value = EasingFunctionsInline.Cubic.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicOut:
                                value = EasingFunctionsInline.Cubic.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicOutIn:
                                value = EasingFunctionsInline.Cubic.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.CubicInOut:
                                value = EasingFunctionsInline.Cubic.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartIn:
                                value = EasingFunctionsInline.Quart.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartOut:
                                value = EasingFunctionsInline.Quart.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartOutIn:
                                value = EasingFunctionsInline.Quart.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuartInOut:
                                value = EasingFunctionsInline.Quart.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintIn:
                                value = EasingFunctionsInline.Quint.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintOut:
                                value = EasingFunctionsInline.Quint.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintOutIn:
                                value = EasingFunctionsInline.Quint.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.QuintInOut:
                                value = EasingFunctionsInline.Quint.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticIn:
                                value = EasingFunctionsInline.Elastic.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticOut:
                                value = EasingFunctionsInline.Elastic.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticOutIn:
                                value = EasingFunctionsInline.Elastic.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.ElasticInOut:
                                value = EasingFunctionsInline.Elastic.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceIn:
                                value = EasingFunctionsInline.Bounce.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceOut:
                                value = EasingFunctionsInline.Bounce.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceOutIn:
                                value = EasingFunctionsInline.Bounce.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BounceInOut:
                                value = EasingFunctionsInline.Bounce.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackIn:
                                value = EasingFunctionsInline.Back.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackOut:
                                value = EasingFunctionsInline.Back.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackOutIn:
                                value = EasingFunctionsInline.Back.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                                break;
                            case EasingType.BackInOut:
                                value = EasingFunctionsInline.Back.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
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
