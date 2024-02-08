static class Program {
    static void Main() {
        Console.WriteLine("Running StrategyClient");
        StrategyClient.Run();

        Console.WriteLine("\nRunning ObserverClient");
        ObserverClient.Run();

        Console.WriteLine("\nRunning DecoratorClient");
        DecoratorClient.Run();

        Console.WriteLine("\nRunning FactoryClient");
        FactoryClient.Run();

        Console.WriteLine("\nRunning SingletonClient");
        SingletonClient.Run();
    }
}