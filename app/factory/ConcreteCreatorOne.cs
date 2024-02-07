class ConcreteCreatorOne : ICreator {
    public IProduct CreateProduct() {
        return new ConcreteProductOne("ConcreteProductOne");
    }
}