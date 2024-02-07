static class FactoryClient {
    public static void Run() {
        // Create a ConcreteCreator and then use it to create a ConcreteProduct
        ConcreteCreatorOne concreteCreatorOne = new();
        IProduct productOne = concreteCreatorOne.CreateProduct();
        productOne.Execute();

        ConcreteCreatorTwo concreteCreatorTwo = new();
        IProduct productTwo = concreteCreatorTwo.CreateProduct();
        productTwo.Execute();
    }
}