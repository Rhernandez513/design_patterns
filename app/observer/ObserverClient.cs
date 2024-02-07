public static class ObserverClient {
    public static void run() {

        Console.WriteLine("Observer Pattern");

        var publisher = new ConcretePublisher();
        var subscriber1 = new ConcreteSubscriber();
        var subscriber2 = new ConcreteSubscriber();
        publisher.Subscribe(subscriber1);
        publisher.Subscribe(subscriber2);
        publisher.NotifySubscribers();
        publisher.Unsubscribe(subscriber1);
        publisher.NotifySubscribers();
        string[] _data = ["Hello ", "from ", "Concrete ", "Publisher!"];
        publisher.NotifySubscribers(_data);
        Console.WriteLine(subscriber2.toString());
    }
}