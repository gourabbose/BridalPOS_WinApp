using Autofac;
using BridalPOS.DataAccess.Interfaces.Base;
using BridalPOS.DataAccess.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.Bootstrapper
{
    public class RepositoryRegistrar : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(BridalPOS.DataAccess.Base.Repository<>)).As(typeof(IRepository<>));

            builder.RegisterType<BridalPOS.DataAccess.Repositories.ActionRepository>().As<IActionRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.CashDrawerRepository>().As<ICashDrawerRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.ClassRepository>().As<IClassRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.ColorRepository>().As<IColorRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.ColorNameListRepository>().As<IColorNameListRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.ColorNameListColorRepository>().As<IColorNameListColorRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.CommissionRepository>().As<ICommissionRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.EventRepository>().As<IEventRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.EventTypeRepository>().As<IEventTypeRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.FabricRepository>().As<IFabricRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.FavoriteRepository>().As<IFavoriteRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.GeneralReportRepository>().As<IGeneralReportRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.InfoSourceRepository>().As<IInfoSourceRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.InventoryRepository>().As<IInventoryRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.ItemStatusRepository>().As<IItemStatusRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.LeadTimeRepository>().As<ILeadTimeRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.MemberRepository>().As<IMemberRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.MemberRoleRepository>().As<IMemberRoleRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.NeckLineRepository>().As<INeckLineRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.NoteRepository>().As<INoteRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.PaymentTypeRepository>().As<IPaymentTypeRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.PurchaseOrderRepository>().As<IPurchaseOrderRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.PurchaseOrderDetailRepository>().As<IPurchaseOrderDetailRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.PurchaseStatusRepository>().As<IPurchaseStatusRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.ReportMessageRepository>().As<IReportMessageRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.SchoolRepository>().As<ISchoolRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.SecurityLevelRepository>().As<ISecurityLevelRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.SilhouetteRepository>().As<ISilhouetteRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.SizeRangeRepository>().As<ISizeRangeRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.SleeveRepository>().As<ISleeveRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.StyleColorRepository>().As<IStyleColorRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.StyleColorNameListRepository>().As<IStyleColorNameListRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.StyleFormatRepository>().As<IStyleFormatRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.StyleMasterRepository>().As<IStyleMasterRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.SysParameterRepository>().As<ISysParameterRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.TicketRepository>().As<ITicketRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.TicketDetailRepository>().As<ITicketDetailRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.TransactionTypeRepository>().As<ITransactionTypeRepository>();
            builder.RegisterType<BridalPOS.DataAccess.Repositories.VendorRepository>().As<IVendorRepository>();

            base.Load(builder);
        }
    }
}
