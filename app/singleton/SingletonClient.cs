class SingletonClient {
    public static void Run() {
        // Create a Singleton and then use it to create a ConcreteProduct
        ConcreteSingleton firstSingleton = ConcreteSingleton.Instance;
        ConcreteSingleton secondSingleton = ConcreteSingleton.Instance;
        firstSingleton.DoSomething();
        Console.WriteLine("firstSingleton == secondSingleton: " + (firstSingleton == secondSingleton));
    }
}