// Made with <3 by Ryan Boyer http://ryanjboyer.com

namespace Easings
{
    public struct Function
    {
        private readonly EasingFunctions.EasingFunction function;

        /// <summary>
        /// Creates an easing function object
        /// </summary>
        /// <param name="function">The function prefab to use</param>
        public Function(EasingFunctions.EasingFunction function) => this.function = function;

        /// <summary>
        /// Ease the function
        /// </summary>
        /// <param name="time">The time to use [0 - duration]</param>
        /// <param name="start">The start value</param>
        /// <param name="delta">The delta value</param>
        /// <param name="duration">The duration to use</param>
        /// <returns>The eased product of [start + delta * time / duration]</returns>
        public float Ease(float time, float start, float delta, float duration) => function(time, start, delta, duration);
    }
}