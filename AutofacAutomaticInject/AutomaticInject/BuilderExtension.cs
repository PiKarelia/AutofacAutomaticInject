using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;

namespace AutofacAutomaticInject.AutomaticInject
{
    public static class BuilderExtension
    {
        public static void RegisterAll(this ContainerBuilder builder, Assembly assembly)
        // TODO: Change to list of assemblies
        {
            var classes = GetTypesWithAttribute(assembly, typeof(RegisterDependencyClassAttribute));
//            var interfaces = GetTypesWithAttribute(assembly, typeof(RegisterDependencyInterfaceAttribute));

            foreach (var cl in classes)
            {
                builder.RegisterType(cl);
            }
        }

        private static IEnumerable<Type> GetTypesWithAttribute(Assembly assembly, Type atributeType)
        {
            return assembly.GetTypes().Where(type => type.GetCustomAttributes(atributeType, true).Any());
        }
    }


}
