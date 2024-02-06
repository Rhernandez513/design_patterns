class Client  {
    static int Main() {

        Console.WriteLine("Strategy Pattern\n");

        runSubtractionStrategy();
        runAdditionStrategy();

        return 0;
    }
    static void runSubtractionStrategy() {
        IStrategy chosenStrategy = new ConcreteStrategyTwo();
        IContext context = new ConcreteContext().IContext(chosenStrategy);

        string data = "3";

        long result = context.Execute(data, 10);

        Console.WriteLine("Subtraction Strategy: " + result);
    }

    static void runAdditionStrategy() {

        IStrategy chosenStrategy = new ConcreteStrategyOne();
        IContext context = new ConcreteContext().IContext(chosenStrategy);

        string data = "3";

        long result = context.Execute(data, 10);

        Console.WriteLine("Addition Strategy: " + result);
    }
}
