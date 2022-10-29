// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using Unity.Mathematics;
using UnityEngine;

namespace Easings {
    public struct Function {
        private readonly EasingFunctions.EasingFunction function;

        /// <summary>
        /// Creates an easing function object
        /// </summary>
        /// <param name="function">The function preset to use</param>
        public Function(EasingFunctions.EasingFunction function) => this.function = function;

        internal float Ease(float time, float start, float delta, float duration) => function(time, start, delta, duration);

        internal Vector2 Ease(float time, Vector2 start, Vector2 delta, float duration) => new Vector2(
            function(time, start.x, delta.x, duration),
            function(time, start.y, delta.y, duration)
        );

        internal Vector3 Ease(float time, Vector3 start, Vector3 delta, float duration) => new Vector3(
            function(time, start.x, delta.x, duration),
            function(time, start.y, delta.y, duration),
            function(time, start.z, delta.z, duration)
        );

        internal Vector4 Ease(float time, Vector4 start, Vector4 delta, float duration) => new Vector4(
            function(time, start.x, delta.x, duration),
            function(time, start.y, delta.y, duration),
            function(time, start.z, delta.z, duration),
            function(time, start.w, delta.w, duration)
        );

        internal Quaternion Ease(float time, Quaternion start, Quaternion delta, float duration) => new Quaternion(
            function(time, start.x, delta.x, duration),
            function(time, start.y, delta.y, duration),
            function(time, start.z, delta.z, duration),
            function(time, start.w, delta.w, duration)
        );

        internal Color Ease(float time, Color start, Color delta, float duration) => new Color(
            function(time, start.r, delta.r, duration),
            function(time, start.g, delta.g, duration),
            function(time, start.b, delta.b, duration),
            function(time, start.a, delta.a, duration)
        );

        internal float2 Ease(float time, float2 start, float2 delta, float duration) => new float2(
            function(time, start.x, delta.x, duration),
            function(time, start.y, delta.y, duration)
        );

        internal float3 Ease(float time, float3 start, float3 delta, float duration) => new float3(
            function(time, start.x, delta.x, duration),
            function(time, start.y, delta.y, duration),
            function(time, start.z, delta.z, duration)
        );

        internal float4 Ease(float time, float4 start, float4 delta, float duration) => new float4(
            function(time, start.x, delta.x, duration),
            function(time, start.y, delta.y, duration),
            function(time, start.z, delta.z, duration),
            function(time, start.w, delta.w, duration)
        );

        internal quaternion Ease(float time, quaternion start, quaternion delta, float duration) => new quaternion(
            function(time, start.value.x, delta.value.x, duration),
            function(time, start.value.y, delta.value.y, duration),
            function(time, start.value.z, delta.value.z, duration),
            function(time, start.value.w, delta.value.w, duration)
        );
    }
}