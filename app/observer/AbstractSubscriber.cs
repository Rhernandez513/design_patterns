abstract class AbstractSubscriber : ISubscriber
{
    protected object _lock = new();
    protected string[]? _data;
    public abstract void Update();
    public virtual void Update(string[] data) {
        if (data != null) {
            lock (_lock) {
                _data = data;
            }
        }
    }
}