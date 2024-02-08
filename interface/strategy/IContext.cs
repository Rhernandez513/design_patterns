interface IContext
{
    IContext IContext(IStrategy strategy);
    long Execute(string a, int b);
}