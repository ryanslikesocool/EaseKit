namespace EaseKit {
    public interface IInterpolator<Value> {
        Value Evaluate(Value start, Value end, float percent);
    }
}