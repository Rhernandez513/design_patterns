public static class DecoratorClient
{
    public static void Run()
    {
        // Create a ConcreteComponent and then wrap it with a ConcreteDecorator
        IComponent component = new ConcreteComponent();
        component = new ConcreteDecorator(component);
        component.Execute();
    }
}