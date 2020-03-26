using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

namespace ifelse.Easings.Entities
{
    [Serializable]
    public struct Interpolator : IComponentData
    {
        public EasingType Function;

        public float Initial;
        public float Target;
        public float Delta;

        public float Time;
        public float Duration;
        public float DeltaTime;

        public float Value;
        public float Percent;

        public bool Done;
        public bool RemoveOnDone;

        public Interpolator(float Initial, float Target, float Duration, bool RemoveOnDone = true)
        {
            this.Initial = Initial;
            this.Target = Target;
            this.Duration = Duration;
            this.RemoveOnDone = RemoveOnDone;

            Function = EasingType.Linear;
            Delta = Target - Initial;
            Time = 0;
            DeltaTime = 0;
            Value = Initial;
            Percent = 0;
            Done = false;
        }

        public Interpolator(float Initial, float Target, float Duration, EasingType Function, bool RemoveOnDone = true)
        {
            this.Initial = Initial;
            this.Target = Target;
            this.Duration = Duration;
            this.Function = Function;
            this.RemoveOnDone = RemoveOnDone;

            Delta = Target - Initial;
            Time = 0;
            DeltaTime = 0;
            Value = Initial;
            Percent = 0;
            Done = false;
        }

        public Interpolator(float Initial, float Target, float Duration, EasingType Function, float DeltaTime, bool RemoveOnDone = true)
        {
            this.Initial = Initial;
            this.Target = Target;
            this.Duration = Duration;
            this.Function = Function;
            this.DeltaTime = DeltaTime;
            this.RemoveOnDone = RemoveOnDone;

            Delta = Target - Initial;
            Time = 0;
            Value = Initial;
            Percent = 0;
            Done = false;
        }
    }
}