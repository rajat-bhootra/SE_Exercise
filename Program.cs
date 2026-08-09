namespace MessageManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageManager TcpManager = new TcpManager();
            TcpManager.SendMessage("Message to TCP");
            Console.WriteLine($"TCP Message Count: {TcpManager.GetMessageCount()}");
            
            IMessageManager HttpManager = new HttpManager();
            HttpManager.SendMessage("Message to HTTP");
            Console.WriteLine($"HTTP Message Count: {HttpManager.GetMessageCount()}");
            HttpManager.SendMessage("Another massage to HTTP");
            Console.WriteLine($"HTTP Message Count: {HttpManager.GetMessageCount()}");

            IMessageManager EncodedTcpManager = new EncodedTcpManager();
            EncodedTcpManager.SendMessage("Message to Encoded TCP");
            Console.WriteLine($"Encoded TCP Message Count: {EncodedTcpManager.GetMessageCount()}");
            EncodedTcpManager.SendMessage("Encode this message");
            Console.WriteLine($"Encoded TCP Message Count: {EncodedTcpManager.GetMessageCount()}");
        }
    }
}
