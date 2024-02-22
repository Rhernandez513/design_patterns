abstract class AbstractPublisher : IPublisher
{
    protected List<ISubscriber> observers = [];

    public abstract void NotifySubscribers(string[] data);

    public void Subscribe(ISubscriber observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(ISubscriber observer)
    {
        observers.Remove(observer);
    }

    public void NotifySubscribers()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}