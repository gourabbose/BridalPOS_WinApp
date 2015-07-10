using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.WinApp
{
    public static class Initializer
    {
        public static void Init()
        {
            //Used to build an Autofac.IContainer from component registrations.
            var builder = new ContainerBuilder();

            // Register Components via their modules(contain registrations for components)
            builder.RegisterAssemblyModules(new[]{
                typeof(BridalPOS.Bootstrapper.ManagerRegistrar).Assembly,
                typeof(BridalPOS.Bootstrapper.RepositoryRegistrar).Assembly
            });

            // Create a new container with the component registrations that have been made.
            var container = builder.Build(Autofac.Builder.ContainerBuildOptions.None);

            //Autofac implementation of the Microsoft CommonServiceLocator.
            //The service locator provides a way to locate a service without specifying the concrete type. Another form of DI.
            var locator = new AutofacServiceLocator(container);

            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}
