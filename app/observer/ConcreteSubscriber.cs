class ConcreteSubscriber : AbstractSubscriber
{
    private readonly string _id = Guid.NewGuid().ToString();
    public override void Update()
    {
        Console.WriteLine("Update called on ConcreteSubscriber: " + _id);
    }
    public override string ToString() {
        _data ??= [];
        string message = "ConcreteSubscriber: " + _id + " " + "Data: " + string.Join("", _data) + "\n";
        return message;
    }
}