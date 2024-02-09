class SingletonClient {
    public static void Run() {
        // Create a Singleton and then use it to create a ConcreteProduct
        Lazy<ConcreteSingleton> lazySingletonOne = ConcreteSingleton.Instance;
        Lazy<ConcreteSingleton> lazySingletonTwo = ConcreteSingleton.Instance;

        lazySingletonOne.Value.DoSomething();
        Console.WriteLine("firstSingleton == secondSingleton: " + (lazySingletonOne == lazySingletonTwo));
    }
}