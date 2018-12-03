using System;
using AutofacAutomaticInject.AutomaticInject;

namespace AutofacAutomaticInject.Dependency
{
    [RegisterDependencyClass]
    public class DependencyObj : IDependencyObj
    {
        public void GetMethod(int value)
        {
            Console.WriteLine("Value is: " + value);
        }
    }
}
