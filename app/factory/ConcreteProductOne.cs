class ConcreteProductOne(string productName) : IProduct {
    private readonly string productName = productName;

    public void Execute() {
        Console.WriteLine("Product.Operate() on ConcreteProductOne with product name " + productName);
    }
}