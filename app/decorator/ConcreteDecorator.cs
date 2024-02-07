class ConcreteDecorator : AbstractDecorator
{
    public ConcreteDecorator(IComponent component) : base(component)
    {
    }

    public override void Execute()
    {
        base.Execute();
        AddedBehavior();
    }

    private void AddedBehavior()
    {
        Console.WriteLine("ConcreteDecorator.AddedBehavior()");
    }
}