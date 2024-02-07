abstract class AbstractPublisher : IPublisher
{
    protected List<ISubscriber> observers = new List<ISubscriber>();

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

    public abstract void NotifySubscribers(string[] data);
}