// Made with <3 by Ryan Boyer http://ryanjboyer.com

#if UNITY_ENTITIES
using Unity.Entities;
using Unity.Jobs;

namespace Easings.Entities
{
    [UpdateInGroup(typeof(SimulationSystemGroup))]
    public class InterpolatorSystemGroup : ComponentSystemGroup { }

#region Base System

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    public class InterpolatorBaseSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            float elapsedTime = (float)Time.ElapsedTime;

            Entities.ForEach((ref InterpolatorLocalTime localTime, in InterpolatorStartTime startTime) => localTime.Value = elapsedTime - startTime.Value).ScheduleParallel();

            Entities.ForEach((ref InterpolatorPercent percent, in InterpolatorLocalTime localTime, in InterpolatorDuration duration) => percent.Value = localTime.Value / duration.Value).ScheduleParallel();

            Entities.ForEach((ref InterpolatorDone done, in InterpolatorPercent percent) => done.Value = percent.Value >= 1).ScheduleParallel();
        }
    }

#endregion

#region Easings

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseLinearSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseLinear>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = percent.Value).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseExpoSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseExpoIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ExpoIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseExpoOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ExpoOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseExpoInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ExpoInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseExpoOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ExpoOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseCircSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseCircIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CircIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseCircOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CircOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();


            Entities
            .WithAll<EaseCircInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CircInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseCircOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CircOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuadSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseQuadIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuadIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuadOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuadOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuadInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuadInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuadOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuadOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseSineSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseSineIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.SineIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseSineOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.SineOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseSineInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.SineInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseSineOutIn ease) => value.Value = EasingFunctions.SineOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseCubicSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseCubicIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CubicIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseCubicOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CubicOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseCubicInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CubicInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseCubicOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.CubicOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuartSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseQuartIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuartIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuartOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuartOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuartInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuartInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuartOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuartOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuintSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseQuintIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuintIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities.WithAll<EaseQuintOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuintOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuintInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuintInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseQuintOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.QuintOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseElasticSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseElasticIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ElasticIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseElasticOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ElasticOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseElasticInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ElasticInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseElasticOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.ElasticOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseBounceSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseBounceIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BounceIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseBounceOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BounceOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseBounceInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BounceInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseBounceOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BounceOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseBackSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseBackIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BackIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseBackOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BackOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseBackInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BackInOut.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();

            Entities
            .WithAll<EaseBackOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) => value.Value = EasingFunctions.BackOutIn.Ease(percent.Value, 0, 1, 1)).ScheduleParallel();
        }
    }

#endregion
}
#endif