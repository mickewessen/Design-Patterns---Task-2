using Design_Patterns_Assignment.Strategy.Message;
using Design_Patterns_Assignment.Strategy.Messagehandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    public class StrategyRun:IStrategyRun
    {
            public ISendMessageHandler Messagehandler { get; set; }
            public ISMS Sms { get; set; }
            public IEmail Email { get; set; }
            public IFacebook Facebook { get; set; }

            public StrategyRun(ISendMessageHandler messagehandler, ISMS sms, IEmail email, IFacebook facebook)
            {
                Messagehandler = messagehandler;
                Sms = sms;
                Email = email;
                Facebook = facebook;
                messagehandler.Message = sms;
            }

            //internal void Run()
            //{
            //    // Refactor this code so that it uses the strategy Pattern


            //    //MessageHandler.Send(message);


            //    // What i want to happen to happen is
            //    //
            //    // Change type of message to send to sms etc.
            //    // send message            
            //}

            public void Run()
            {
                Console.WriteLine("Strategy");
                //var message = "This is the message";
                //Messagehandler.Send(message);
            }
        }
    }
    
