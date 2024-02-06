class ConcreteStrategyOne : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("ConcreteStrategyOne.Execute()");
    }

    public long Execute(string a, int b)
    {
        Console.WriteLine("ConcreteStrategyOne.Execute(string, int)");
        Console.WriteLine("Addition Strategy");
        try {
            long result = int.Parse(a) + b;
            return result;
        } catch (Exception e) {
            Console.WriteLine(e.Message);   
            return 1;
        }
    }
}