class ConcreteStrategyTwo : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("ConcreteStrategyTwo.Execute()");
    }

    public long Execute(string a, int b)
    {
        Console.WriteLine("ConcreteStrategyTwo.Execute(string, int)");
        Console.WriteLine("Subtraction Strategy");
        try {
            long result = int.Parse(a) - b;
            return result;
        } catch (Exception e) {
            Console.WriteLine(e.Message);   
            return 1;
        }
    }
}