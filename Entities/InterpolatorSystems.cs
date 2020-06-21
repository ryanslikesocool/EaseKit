using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace ifelse.Easings.Entities
{
    #region Base System
    [UpdateInGroup(typeof(SimulationSystemGroup))]
    public class InterpolatorSystemGroup : ComponentSystemGroup { }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    public class InterpolatorBaseSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            float elapsedTime = (float)Time.ElapsedTime;

            Dependency = Entities.ForEach((ref InterpolatorLocalTime localTime, in InterpolatorStartTime startTime) =>
            {
                localTime.Value = elapsedTime - startTime.Value;
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorPercent percent, in InterpolatorLocalTime localTime, in InterpolatorDuration duration) =>
            {
                percent.Value = localTime.Value / duration.Value;
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorDone done, in InterpolatorPercent percent) =>
            {
                done.Value = percent.Value >= 1;
            }).Schedule(Dependency);

            //CompleteDependency();
        }
    }
    #endregion

    #region Easings

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseLinearSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseLinear ease) =>
            {
                value.Value = percent.Value;
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseExpoSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseExpoIn ease) =>
            {
                value.Value = EasingFunctionsInline.Expo.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseExpoOut ease) =>
            {
                value.Value = EasingFunctionsInline.Expo.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseExpoInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Expo.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseExpoOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Expo.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseCircSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCircIn ease) =>
            {
                value.Value = EasingFunctionsInline.Circ.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCircOut ease) =>
            {
                value.Value = EasingFunctionsInline.Circ.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCircInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Circ.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCircOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Circ.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuadSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuadIn ease) =>
            {
                value.Value = EasingFunctionsInline.Quad.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuadOut ease) =>
            {
                value.Value = EasingFunctionsInline.Quad.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuadInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Quad.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuadOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Quad.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseSineSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseSineIn ease) =>
            {
                value.Value = EasingFunctionsInline.Sine.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseSineOut ease) =>
            {
                value.Value = EasingFunctionsInline.Sine.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseSineInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Sine.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseSineOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Sine.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseCubicSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCubicIn ease) =>
            {
                value.Value = EasingFunctionsInline.Cubic.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCubicOut ease) =>
            {
                value.Value = EasingFunctionsInline.Cubic.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCubicInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Cubic.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseCubicOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Cubic.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuartSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuartIn ease) =>
            {
                value.Value = EasingFunctionsInline.Quart.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuartOut ease) =>
            {
                value.Value = EasingFunctionsInline.Quart.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuartInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Quart.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuartOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Quart.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseQuintSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuintIn ease) =>
            {
                value.Value = EasingFunctionsInline.Quint.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuintOut ease) =>
            {
                value.Value = EasingFunctionsInline.Quint.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuintInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Quint.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseQuintOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Quint.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseElasticSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseElasticIn ease) =>
            {
                value.Value = EasingFunctionsInline.Elastic.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseElasticOut ease) =>
            {
                value.Value = EasingFunctionsInline.Elastic.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseElasticInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Elastic.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseElasticOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Elastic.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseBounceSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBounceIn ease) =>
            {
                value.Value = EasingFunctionsInline.Bounce.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBounceOut ease) =>
            {
                value.Value = EasingFunctionsInline.Bounce.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBounceInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Bounce.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBounceOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Bounce.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    [UpdateInGroup(typeof(InterpolatorSystemGroup))]
    [UpdateAfter(typeof(InterpolatorBaseSystem))]
    public class EaseBackSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBackIn ease) =>
            {
                value.Value = EasingFunctionsInline.Back.EaseIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);

            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBackOut ease) =>
            {
                value.Value = EasingFunctionsInline.Back.EaseOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBackInOut ease) =>
            {
                value.Value = EasingFunctionsInline.Back.EaseInOut(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);


            Dependency = Entities.ForEach((ref InterpolatorValue value, in InterpolatorPercent percent, in EaseBackOutIn ease) =>
            {
                value.Value = EasingFunctionsInline.Back.EaseOutIn(percent.Value, 0, 1, 1);
            }).Schedule(Dependency);
        }
    }

    #endregion
}