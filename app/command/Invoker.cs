class Invoker(ICommand command) {
    private readonly ICommand _command = command;
    public void Execute() {
        _command.Execute();
    }
    public void Undo() {
        _command.Undo();
    }
}