// Made with <3 by Ryan Boyer http://ryanjboyer.com

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

            Entities.ForEach((ref InterpolatorLocalTime localTime, in InterpolatorStartTime startTime) =>
            {
                localTime.Value = elapsedTime - startTime.Value;
            }).ScheduleParallel();

            Entities.ForEach((ref InterpolatorPercent percent, in InterpolatorLocalTime localTime, in InterpolatorDuration duration) =>
            {
                percent.Value = localTime.Value / duration.Value;
            }).ScheduleParallel();

            Entities.ForEach((ref InterpolatorDone done, in InterpolatorPercent percent) =>
            {
                done.Value = percent.Value >= 1;
            }).ScheduleParallel();
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
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
           {
               value.Value = percent.Value;
           }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseExpoSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseExpoIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Expo.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseExpoOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Expo.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseExpoInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Expo.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseExpoOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Expo.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseCircSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseCircIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Circ.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseCircOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Circ.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();


            Entities
            .WithAll<EaseCircInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Circ.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseCircOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Circ.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuadSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseQuadIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quad.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuadOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quad.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuadInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quad.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuadOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quad.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseSineSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseSineIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Sine.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseSineOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Sine.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseSineInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Sine.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseSineOutIn ease) =>
            {
                value.Value = InlineEasings.Sine.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseCubicSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseCubicIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Cubic.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseCubicOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Cubic.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseCubicInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Cubic.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseCubicOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Cubic.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuartSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseQuartIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quart.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuartOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quart.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuartInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quart.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuartOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quart.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuintSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseQuintIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quint.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities.WithAll<EaseQuintOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quint.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuintInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quint.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseQuintOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Quint.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseElasticSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseElasticIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Elastic.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseElasticOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Elastic.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseElasticInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Elastic.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseElasticOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Elastic.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseBounceSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseBounceIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Bounce.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseBounceOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Bounce.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseBounceInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Bounce.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseBounceOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Bounce.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup)), UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseBackSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities
            .WithAll<EaseBackIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Back.EaseIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseBackOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Back.EaseOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseBackInOut>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Back.EaseInOut(percent.Value, 0, 1, 1);
            }).ScheduleParallel();

            Entities
            .WithAll<EaseBackOutIn>()
            .ForEach((ref InterpolatorValue value, in InterpolatorPercent percent) =>
            {
                value.Value = InlineEasings.Back.EaseOutIn(percent.Value, 0, 1, 1);
            }).ScheduleParallel();
        }
    }

    #endregion
}