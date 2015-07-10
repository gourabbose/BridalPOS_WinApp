using BridalPOS.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.DataAccess.Interfaces.Repositories
{
    public interface IActionRepository : Base.IRepository<BridalPOS.Models.Core.Action> { }
    public interface ICashDrawerRepository : Base.IRepository<CashDrawer> { }
    public interface IClassRepository : Base.IRepository<Class> { }
    public interface IColorRepository : Base.IRepository<Color> { }
    public interface IColorNameListRepository : Base.IRepository<ColorNameList> { }
    public interface IColorNameListColorRepository : Base.IRepository<ColorNameListColor> { }
    public interface ICommissionRepository : Base.IRepository<Commission> { }
    public interface IEmployeeRepository : Base.IRepository<Employee> { }
    public interface IEventRepository : Base.IRepository<Event> { }
    public interface IEventTypeRepository : Base.IRepository<EventType> { }
    public interface IFabricRepository : Base.IRepository<Fabric> { }
    public interface IFavoriteRepository : Base.IRepository<Favorite> { }
    public interface IGeneralReportRepository : Base.IRepository<GeneralReport> { }
    public interface IInfoSourceRepository : Base.IRepository<InfoSource> { }
    public interface IInventoryRepository : Base.IRepository<Inventory> { }
    public interface IItemStatusRepository : Base.IRepository<ItemStatus> { }
    public interface ILeadTimeRepository : Base.IRepository<LeadTime> { }
    public interface IMemberRepository : Base.IRepository<Member> { }
    public interface IMemberRoleRepository : Base.IRepository<MemberRole> { }
    public interface INeckLineRepository : Base.IRepository<NeckLine> { }
    public interface INoteRepository : Base.IRepository<Note> { }
    public interface IPaymentTypeRepository : Base.IRepository<PaymentType> { }
    public interface IPurchaseOrderRepository : Base.IRepository<PurchaseOrder> { }
    public interface IPurchaseOrderDetailRepository : Base.IRepository<PurchaseOrderDetail> { }
    public interface IPurchaseStatusRepository : Base.IRepository<PurchaseStatus> { }
    public interface IReportMessageRepository : Base.IRepository<ReportMessage> { }
    public interface ISchoolRepository : Base.IRepository<School> { }
    public interface ISecurityLevelRepository : Base.IRepository<SecurityLevel> { }
    public interface ISilhouetteRepository : Base.IRepository<Silhouette> { }
    public interface ISizeRangeRepository : Base.IRepository<SizeRange> { }
    public interface ISleeveRepository : Base.IRepository<Sleeve> { }
    public interface IStyleColorRepository : Base.IRepository<StyleColor> { }
    public interface IStyleColorNameListRepository : Base.IRepository<StyleColorNameList> { }
    public interface IStyleFormatRepository : Base.IRepository<StyleFormat> { }
    public interface IStyleMasterRepository : Base.IRepository<StyleMaster> { }
    public interface ISysParameterRepository : Base.IRepository<SysParameter> { }
    public interface ITicketRepository : Base.IRepository<Ticket> { }
    public interface ITicketDetailRepository : Base.IRepository<TicketDetail> { }
    public interface ITransactionTypeRepository : Base.IRepository<TransactionType> { }
    public interface IVendorRepository : Base.IRepository<Vendor> { }
}                    