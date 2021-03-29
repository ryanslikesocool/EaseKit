// Made with <3 by Ryan Boyer http://ryanjboyer.com

namespace Easings
{
    public interface IFunction
    {
        float Ease(float time, float start, float delta, float duration);
    }
}