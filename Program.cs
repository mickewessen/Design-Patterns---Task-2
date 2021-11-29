using Design_Patterns_Assignment;
using Autofac;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AFConfig.Configure();

            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();
        }     
    }
}
