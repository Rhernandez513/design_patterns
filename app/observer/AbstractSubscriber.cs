abstract class AbstractSubscriber : ISubscriber
{
    protected string[]? _data;
    public abstract void Update();
    public void Update(string[] data) {
        if (data != null) {
            _data = data;
        }
    }
}