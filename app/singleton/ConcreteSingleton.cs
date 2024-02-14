class ConcreteSingleton : AbstractSingleton<ConcreteSingleton>
{
    public void Execute() {
        Console.WriteLine("ConcreteSingleton.Execute()");
    }
}