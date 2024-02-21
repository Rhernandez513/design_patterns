class Adapter : IClientInterface {
<<<<<<< Updated upstream
    private int adapteeService;

=======
    private readonly int adapteeService;
 
>>>>>>> Stashed changes
    public void Send(string data) {
        Console.WriteLine("Adapter.Send()");
        string formattedData = data + " formatted";
        Console.WriteLine("adapteeService.invoke(formattedData)");
<<<<<<< Updated upstream
        this.adapteeServiceInvoke(formattedData);
    }

    private void adapteeServiceInvoke(string formattedData) {
=======
        adapteeServiceInvoke(formattedData);
    }

    private void adapteeServiceInvoke(string formattedData) {
        // example
        // adapteeService.Invoke(formattedData);
>>>>>>> Stashed changes
        Console.WriteLine("AdapteeService.Invoke(string formattedData)");
        Console.WriteLine("Sending \"" + formattedData + "\" to AdapteeService");
    }
}