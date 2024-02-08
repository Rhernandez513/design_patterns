abstract class AbstractDecorator(IComponent component) : IComponent
{
    protected IComponent _component = component;

    public virtual void Execute()
    {
        _component.Execute();
    }
}