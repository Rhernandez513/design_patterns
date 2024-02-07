class ConcreteCreatorTwo : ICreator {
    public IProduct CreateProduct() {
        const int productCode = 3;
        return new ConcreteProductTwo(productCode);
    }
}