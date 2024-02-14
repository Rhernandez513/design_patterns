class SingletonClient {
    public static void Run() {
        ConcreteSingleton lazySingletonOne = ConcreteSingleton.Instance;
        ConcreteSingleton lazySingletonTwo = ConcreteSingleton.Instance;

        lazySingletonOne.Execute();
        Console.WriteLine("firstSingleton == secondSingleton: " + (lazySingletonOne == lazySingletonTwo));
    }
}