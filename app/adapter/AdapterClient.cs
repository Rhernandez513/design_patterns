class AdapterClient {
    public static void Run() {
        IClientInterface client = new Adapter();
        client.Send("Hello, World!");
    }
}