class ConcreteCommandOne(Receiver receiver) : ICommand
{
    private readonly Receiver _receiver = receiver;

    public void Execute() 
    {
        Console.WriteLine("ConcreteCommandOne.Execute()");
        _receiver.Operation();
    }

    public void Undo() => Console.WriteLine("ConcreteCommandOne.Undo()");
}