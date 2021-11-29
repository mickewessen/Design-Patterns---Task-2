using Design_Patterns_Assignment.Strategy.Message;
using Design_Patterns_Assignment.Strategy.Messagehandler;

namespace Design_Patterns_Assignment.Strategy
{
    public interface IStrategyRun
    {
        IEmail Email { get; set; }
        IFacebook Facebook { get; set; }
        ISendMessageHandler Messagehandler { get; set; }
        ISMS Sms { get; set; }

        void Run();
    }
}