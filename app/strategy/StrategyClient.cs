class StrategyClient  {
    public static int Run() {

        Console.WriteLine("Strategy Pattern");

        RunSubtractionStrategy();
        RunAdditionStrategy();

        return 0;
    }
    static void RunSubtractionStrategy() {
        IStrategy chosenStrategy = new ConcreteStrategyTwo();
        IContext context = new ConcreteContext().IContext(chosenStrategy);

        string data = "3";

        long result = context.Execute(data, 10);

        Console.WriteLine("Subtraction Strategy: " + result);
    }

    static void RunAdditionStrategy() {

        IStrategy chosenStrategy = new ConcreteStrategyOne();
        IContext context = new ConcreteContext().IContext(chosenStrategy);

        string data = "3";

        long result = context.Execute(data, 10);

        Console.WriteLine("Addition Strategy: " + result);
    }
}
