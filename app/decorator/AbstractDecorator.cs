abstract class AbstractDecorator : IComponent
{
    protected IComponent _component;

    public AbstractDecorator(IComponent component)
    {
        _component = component;
    }

    public virtual void Execute()
    {
        _component.Execute();
    }
}