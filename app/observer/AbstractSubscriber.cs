abstract class AbstractSubscriber : ISubscriber
{
    private byte[] _data;
    private List<IPublisher> subscriptions = new List<IPublisher>();

    public abstract void Update();
    public void Update(byte[] data) {
        if (data != null) {
            _data = data;
        }
    }
}