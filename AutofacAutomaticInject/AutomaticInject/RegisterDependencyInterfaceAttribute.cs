using System;

namespace AutofacAutomaticInject.AutomaticInject
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = true)]
    public class RegisterDependencyInterfaceAttribute : Attribute{}
}
