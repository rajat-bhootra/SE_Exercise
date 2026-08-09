using System;
using System.Collections.Generic;
using System.Text;

namespace MessageManager
{
    public interface IMessageManager
    {
        void SendMessage(string message);
        int GetMessageCount();
    }
}
