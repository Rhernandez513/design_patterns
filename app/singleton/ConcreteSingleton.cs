class ConcreteSingleton {
    private static ConcreteSingleton? _instance;
    private ConcreteSingleton() { }
    public static ConcreteSingleton Instance {
        get {
            if (_instance == null) {
                _instance = new ConcreteSingleton();
            }
            return _instance;
        }
    }
    public void DoSomething() {
        Console.WriteLine("Doing something...");
    }
}