using System;
using System.Collections.Generic;
using System.Text;

namespace MessageManager
{
    public class EncodedTcpManager : TcpManager
    {
        public override void SendMessage(string message)
        {
            MessageCount++;
            string EncodedMessage = Convert.ToBase64String(Encoding.UTF8.GetBytes(message));
            Console.WriteLine($"Sending message using Encoded TCP: {EncodedMessage}");
        }
    }
}
