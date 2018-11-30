using System;
using Autofac;
using Autofac.Core;
using AutofacAutomaticInject.Dependency;
using AutofacAutomaticInject.High;

namespace AutofacAutomaticInject
{
    public class Startup
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MightyClass>().WithParameter(new ResolvedParameter(
                (p, c) => p.ParameterType == typeof(IDependencyObj),
                (p, c) => c.Resolve<IDependencyObj>())
            ).As<IMightyInterface>();

            builder.RegisterType<DependencyObj>().As<IDependencyObj>();
            

            Container = builder.Build();

            SomeCalculations();
            Console.WriteLine("All was done");
            Console.ReadKey();
        }

        public static void SomeCalculations()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var dependency = scope.Resolve<IMightyInterface>();

                dependency.DoTheWork(42);
            }

//            var type = typeof(IMightyInterface);

//            var atributes = type.GetCustomAttributes(false);

        }
    }
}
