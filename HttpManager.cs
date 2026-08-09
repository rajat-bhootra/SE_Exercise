using System;
using System.Collections.Generic;
using System.Text;

namespace MessageManager
{
    public class HttpManager : IMessageManager
    {
        private int MessageCount = 0; 
        public void SendMessage(string message)
        {
            MessageCount++;
            Console.WriteLine($"Sending message using HTTP: {message}");
        }
        public int GetMessageCount()
        {
            return MessageCount;
        }
    }
}
