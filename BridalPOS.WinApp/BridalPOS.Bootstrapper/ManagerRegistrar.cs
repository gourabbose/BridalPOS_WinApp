using Autofac;
using BridalPOS.Business.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Bootstrapper
{
    public class ManagerRegistrar : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(BridalPOS.Business.Base.Manager<>)).As(typeof(IManager<>));

            base.Load(builder);
        }
    }
}
