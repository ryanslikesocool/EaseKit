// Made with <3 by Ryan Boyer http://ryanjboyer.com

namespace Easings
{
    public struct Function : IFunction
    {
        private readonly EasingFunctions.EasingFunction function;

        public Function(EasingFunctions.EasingFunction function)
        {
            this.function = function;
        }

        public float Ease(float time, float start, float delta, float duration)
        {
            return function(time, start, delta, duration);
        }
    }
}