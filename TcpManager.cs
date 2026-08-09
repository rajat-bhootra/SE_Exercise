using System;
using System.Collections.Generic;
using System.Text;

namespace MessageManager
{
    public class TcpManager : IMessageManager
    {
        protected int MessageCount = 0;
        public virtual void SendMessage(string message)
        {
            MessageCount++;
            Console.WriteLine($"Sending message using TCP: {message}");
        }
        public int GetMessageCount()
        {
            return MessageCount;
        }
    }
}
