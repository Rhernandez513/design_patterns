abstract class AbstractSingleton<T> {
    private static Lazy<T>? instance;
    public static Lazy<T> Instance {
        get {
            if (instance == null) {
                instance = new Lazy<T>(() => Activator.CreateInstance<T>());
                // instance = Activator.CreateInstance<T>();
            }
            return instance;
        }
    }
    protected AbstractSingleton() { }
}