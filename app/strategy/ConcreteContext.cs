class ConcreteContext : IContext {
    private IStrategy? _strategy;

    public IContext IContext(IStrategy strategy) {
        _strategy = strategy;
        return this;
    }
    public long Execute(string a, int b) {
        if (_strategy == null) {
            return -1;
        }
        return _strategy.Execute(a, b);
    }
}