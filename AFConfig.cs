using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<Application>();

            // Register Message
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Message"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

            // Register Messagehandler
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Messagehandler"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();

            // Register StrategyRun
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("StrategyRun"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name))
                   .AsImplementedInterfaces();
            return builder.Build();
        }
    }
}
