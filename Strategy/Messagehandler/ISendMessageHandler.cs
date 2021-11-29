using Design_Patterns_Assignment.Strategy.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.Messagehandler
{
    public interface ISendMessageHandler
    {
        IMessage Message { get; set; }

        void Send(string message);
    }
}
