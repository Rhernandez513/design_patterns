class CommandClient {
    public static void Run() {
        ICommand commandOne = new ConcreteCommandOne(new Receiver());
        Invoker invokerOne = new(commandOne);
        Invoker invokerTwo = new(new ConcreteCommandTwo());

        // Execute a command with an optional receiver
        invokerOne.Execute();
        // Execute a command without a receiver
        invokerTwo.Execute();
    }
}