class ConcreteSubscriber : AbstractSubscriber
{
    private object _call_count_lock = new();
    private int callCount = 0;
    private readonly string _id = Guid.NewGuid().ToString();
    public override void Update()
    {
        incrementCallCount();
        Console.WriteLine("Update #"+callCount+" called on ConcreteSubscriber: " + _id);
    }

    public override void Update(string[] data)
    {
        incrementCallCount();
        base.Update(data);
        Console.WriteLine("Data updated on ConcreteSubscriber: " + _id);
        Console.WriteLine("Update #"+callCount+" called on ConcreteSubscriber: " + _id);
    }
    public override string ToString() {
        _data ??= [];
        string message = "ConcreteSubscriber: " + _id + " " + "Data: " + string.Join("", _data) + "\n";
        return message;
    }
    private void incrementCallCount() {
        lock (_call_count_lock) {
            callCount++;
        }
    }
}