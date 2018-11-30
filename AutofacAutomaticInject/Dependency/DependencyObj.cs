using System;

namespace AutofacAutomaticInject.Dependency
{
    public class DependencyObj : IDependencyObj
    {
        public void GetMethod(int value)
        {
            Console.WriteLine("Value is: " + value);
        }
    }
}
