class ConcretePublisher : AbstractPublisher
{
    public override void NotifySubscribers(string [] data)
    {
        foreach (var observer in observers)
        {
            observer.Update(data);
        }
    }
}