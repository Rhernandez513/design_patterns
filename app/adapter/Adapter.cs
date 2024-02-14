class Adapter : IClientInterface {
    private int adapteeService;

    public void Send(string data) {
        Console.WriteLine("Adapter.Send()");
        string formattedData = data + " formatted";
        Console.WriteLine("adapteeService.invoke(formattedData)");
        this.adapteeServiceInvoke(formattedData);
    }

    private void adapteeServiceInvoke(string formattedData) {
        Console.WriteLine("AdapteeService.Invoke(string formattedData)");
        Console.WriteLine("Sending \"" + formattedData + "\" to AdapteeService");
    }
}