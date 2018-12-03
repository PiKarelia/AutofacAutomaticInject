using System;

namespace AutofacAutomaticInject.AutomaticInject
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class RegisterDependencyClassAttribute: Attribute{}
}
