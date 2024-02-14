abstract class AbstractSingleton<T> where T : new() {
    private static readonly Lazy<T> instance;
    public static T Instance { get { return instance.Value; } }
    static AbstractSingleton() { 
        instance = new Lazy<T>(() => new T());
    }
}