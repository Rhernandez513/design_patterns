class ConcreteSubscriber : AbstractSubscriber
{
    private int callCount = 0;
    private readonly string _id = Guid.NewGuid().ToString();
    public override void Update()
    {
        Interlocked.Increment(ref callCount);
        Console.WriteLine("Update #"+callCount+" called on ConcreteSubscriber: " + _id);
    }

    public override void Update(string[] data)
    {
        Interlocked.Increment(ref callCount);
        base.Update(data);
        Console.WriteLine("Data updated on ConcreteSubscriber: " + _id);
        Console.WriteLine("Update #"+callCount+" called on ConcreteSubscriber: " + _id);
    }
    public override string ToString() {
        _data ??= [];
        string message = "ConcreteSubscriber: " + _id + " " + "Data: " + string.Join("", _data) + "\n";
        return message;
    }
}