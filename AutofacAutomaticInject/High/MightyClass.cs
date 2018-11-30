using AutofacAutomaticInject.Dependency;

namespace AutofacAutomaticInject.High
{
    public class MightyClass : IMightyInterface
    {
        private readonly IDependencyObj _dependency;

        public MightyClass(IDependencyObj dependencyObj)
            => _dependency = dependencyObj;
        
        public void DoTheWork(int value)
        {
            _dependency.GetMethod(value);
        }
    }
}
