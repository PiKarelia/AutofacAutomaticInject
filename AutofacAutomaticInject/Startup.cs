using System;
using System.Reflection;
using Autofac;
using AutofacAutomaticInject.AutomaticInject;
using AutofacAutomaticInject.Dependency;

namespace AutofacAutomaticInject
{
    public class Startup
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterAll(Assembly.GetAssembly(typeof(Startup)));
            Container = builder.Build();

            SomeCalculations();
            Console.WriteLine("All was done");
            Console.ReadKey();
        }

        public static void SomeCalculations()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
//                var dependency = scope.Resolve<IDependencyObj>();
                var dependency = scope.Resolve<DependencyObj>();

                dependency.GetMethod(42);
            }
        }
    }
}
