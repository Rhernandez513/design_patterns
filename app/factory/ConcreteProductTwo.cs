class ConcreteProductTwo(int productCode) : IProduct {
    private readonly int productCode = productCode;

    public void Execute() {
        Console.WriteLine("Product.Operate() on ConcreteProductTwo with product code " + productCode);
    }
}