using Design_Patterns_Assignment.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Application
    {
        public static void Run()
        {
            Decorator.Run();            
            Repository.Run();
            StrategyRun.Run();
            Observer.Run();
        }

    }
}
