using AutofacAutomaticInject.AutomaticInject;

namespace AutofacAutomaticInject.Dependency
{
    [RegisterDependencyInterface]
    public interface IDependencyObj
    {
        void GetMethod(int value);
    }
}
