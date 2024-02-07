class ConcreteSubscriber : AbstractSubscriber
{
    private string _id = Guid.NewGuid().ToString();
    public override void Update()
    {
        Console.WriteLine("Update called on ConcreteSubscriber: " + _id);
    }
    public string toString() {
        _data = _data ?? [];
        string message = "ConcreteSubscriber: " + _id + " " + "Data: " + string.Join("", _data) + "\n";
        return message;
    }
}