class ConcreteDecorator(IComponent component) : AbstractDecorator(component)
{
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