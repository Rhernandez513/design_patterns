class Receiver {
    public void Operation() => Console.WriteLine("Receiver.operation()");
    public int Operation(int a, int b, int c) {
        Console.WriteLine("Receiver.operation(int a, int b, int c)");
        return a + b + c;
    }
}