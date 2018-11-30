using System;

namespace AutofacAutomaticInject
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public class RegisterDependencyAttribute : Attribute
    {
        public RegisterDependencyAttribute()
        {
            Console.WriteLine("Atribute created");
        }
    }
}
