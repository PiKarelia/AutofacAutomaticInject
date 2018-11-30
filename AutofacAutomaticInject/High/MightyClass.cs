using System;
using AutofacAutomaticInject.Dependency;

namespace AutofacAutomaticInject.High
{
    public class MightyClass : IMightyInterface
    {
        private readonly IDependencyObj _dependency;

        public MightyClass(IDependencyObj dependencyObj)
            => _dependency = dependencyObj;


//        public void DoTheWork() =>
//            Console.WriteLine("THE WORK, dependency is "
//                              + ((_dependency == null) ? "NULL" : "NOT NULL"));
        public void DoTheWork(int value)
        {
            _dependency.GetMethod(value);
        }
    }
}
