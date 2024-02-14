class ConcreteCommandTwo : ICommand {
    public void Execute() => Console.WriteLine("ConcreteCommandTwo.Execute()");
    public void Undo() => Console.WriteLine("ConcreteCommandTwo.Undo()");
}