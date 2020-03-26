using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using static Unity.Mathematics.math;

namespace ifelse.Easings.Entities
{
    [UpdateInGroup(typeof(SimulationSystemGroup))]
    public class InterpolationSystem : JobComponentSystem
    {
        private BeginInitializationEntityCommandBufferSystem entityCommandBufferSystem;

        protected override void OnCreate()
        {
            entityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
        }

        [BurstCompile]
        struct InterpolateJob : IJobForEach<Interpolator>
        {
            public float deltaTime;

            public void Execute(ref Interpolator interpolator)
            {
                float delta = interpolator.DeltaTime <= 0 ? deltaTime : interpolator.DeltaTime;
                interpolator.Time += delta;

                float value = 0;

                if (interpolator.Time > interpolator.Duration)
                {
                    interpolator.Time = interpolator.Duration;
                    interpolator.Value = interpolator.Target;
                    interpolator.Done = true;
                    interpolator.Percent = 1;
                    return;
                }

                if (interpolator.Percent < 1)
                {
                    interpolator.Percent = interpolator.Time / interpolator.Duration;

                    switch (interpolator.Function)
                    {
                        case EasingType.Linear:
                            value = Easing.Linear.Ease(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ExpoIn:
                            value = Easing.Expo.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ExpoOut:
                            value = Easing.Expo.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ExpoOutIn:
                            value = Easing.Expo.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ExpoInOut:
                            value = Easing.Expo.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CircIn:
                            value = Easing.Circ.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CircOut:
                            value = Easing.Circ.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CircOutIn:
                            value = Easing.Circ.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CircInOut:
                            value = Easing.Circ.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuadIn:
                            value = Easing.Quad.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuadOut:
                            value = Easing.Quad.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuadOutIn:
                            value = Easing.Quad.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuadInOut:
                            value = Easing.Quad.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.SineIn:
                            value = Easing.Sine.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.SineOut:
                            value = Easing.Sine.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.SineOutIn:
                            value = Easing.Sine.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.SineInOut:
                            value = Easing.Sine.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CubicIn:
                            value = Easing.Cubic.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CubicOut:
                            value = Easing.Cubic.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CubicOutIn:
                            value = Easing.Cubic.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.CubicInOut:
                            value = Easing.Cubic.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuartIn:
                            value = Easing.Quart.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuartOut:
                            value = Easing.Quart.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuartOutIn:
                            value = Easing.Quart.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuartInOut:
                            value = Easing.Quart.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuintIn:
                            value = Easing.Quint.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuintOut:
                            value = Easing.Quint.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuintOutIn:
                            value = Easing.Quint.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.QuintInOut:
                            value = Easing.Quint.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ElasticIn:
                            value = Easing.Elastic.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ElasticOut:
                            value = Easing.Elastic.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ElasticOutIn:
                            value = Easing.Elastic.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.ElasticInOut:
                            value = Easing.Elastic.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BounceIn:
                            value = Easing.Bounce.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BounceOut:
                            value = Easing.Bounce.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BounceOutIn:
                            value = Easing.Bounce.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BounceInOut:
                            value = Easing.Bounce.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BackIn:
                            value = Easing.Back.EaseIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BackOut:
                            value = Easing.Back.EaseOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BackOutIn:
                            value = Easing.Back.EaseOutIn(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                        case EasingType.BackInOut:
                            value = Easing.Back.EaseInOut(interpolator.Time, interpolator.Initial, interpolator.Delta, interpolator.Duration);
                            break;
                    }
                    interpolator.Value = value;
                }
            }
        }

        [BurstCompile]
        struct InterpolatorCompleteJob : IJobForEachWithEntity<Interpolator>
        {
            public EntityCommandBuffer.Concurrent commandBuffer;

            public void Execute(Entity entity, int index, [ReadOnly] ref Interpolator interpolator)
            {
                if (interpolator.Done && interpolator.RemoveOnDone)
                {
                    commandBuffer.RemoveComponent<Interpolator>(index, entity);
                }
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDependencies)
        {
            InterpolateJob interpolateJob = new InterpolateJob
            {
                deltaTime = Time.DeltaTime
            };
            inputDependencies = interpolateJob.Schedule(this, inputDependencies);

            InterpolatorCompleteJob interpolatorCompleteJob = new InterpolatorCompleteJob
            {
                commandBuffer = entityCommandBufferSystem.CreateCommandBuffer().ToConcurrent()
            };
            inputDependencies = interpolatorCompleteJob.Schedule(this, inputDependencies);

            inputDependencies.Complete();

            return inputDependencies;
        }
    }
}