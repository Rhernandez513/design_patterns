class ConcreteSingleton : AbstractSingleton<ConcreteSingleton>
{
    public void DoSomething() {
        Console.WriteLine("ConcreteSingletonTwo.DoSomething()");
    }
}