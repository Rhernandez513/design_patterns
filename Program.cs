using System.Net;

static class Program {
    static void Main() {
        Console.WriteLine("Running StrategyClient");
        StrategyClient.run();

        Console.WriteLine("\nRunning ObserverClient");
        ObserverClient.run();
    }
}