using Design_Patterns_Assignment.Strategy.Messagehandler;
using Design_Patterns_Assignment.Strategy.Message;
using System;

namespace Design_Patterns_Assignment.Strategy.Messagehandler
{
    internal class SendMessageHandler: ISendMessageHandler
    {
        public IMessage Message { get; set; }

        public void Send(string message)
        {
            Message.Send(message);
        }
    }
}