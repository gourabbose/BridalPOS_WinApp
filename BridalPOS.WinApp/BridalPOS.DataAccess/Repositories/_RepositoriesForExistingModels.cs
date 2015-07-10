using BridalPOS.Models.Core;
using BridalPOS.DataAccess.Base;
//------------------------------------------------------------------------------
// <Notes>
//    This code is for Repositories with Base functionalities for existing modules only.
//    If this Repositories need more features, those whould be written in different class file as partial classes with these.
//    [GOURAB 10-Jul-2015]
// </Notes>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridalPOS.DataAccess.Interfaces.Repositories;

namespace BridalPOS.DataAccess.Repositories
{
    public partial class ActionRepository : Repository<BridalPOS.Models.Core.Action>, IActionRepository { }
    public partial class CashDrawerRepository : Repository<CashDrawer>, ICashDrawerRepository { }
    public partial class ClassRepository : Repository<Class>, IClassRepository { }
    public partial class ColorRepository : Repository<Color>, IColorRepository { }
    public partial class ColorNameListRepository : Repository<ColorNameList>, IColorNameListRepository { }
    public partial class ColorNameListColorRepository : Repository<ColorNameListColor>, IColorNameListColorRepository { }
    public partial class CommissionRepository : Repository<Commission>, ICommissionRepository { }
    public partial class EmployeeRepository : Repository<Employee>, IEmployeeRepository { }
    public partial class EventRepository : Repository<Event>, IEventRepository { }
    public partial class EventTypeRepository : Repository<EventType>, IEventTypeRepository { }
    public partial class FabricRepository : Repository<Fabric>, IFabricRepository { }
    public partial class FavoriteRepository : Repository<Favorite>, IFavoriteRepository { }
    public partial class GeneralReportRepository : Repository<GeneralReport>, IGeneralReportRepository { }
    public partial class InfoSourceRepository : Repository<InfoSource>, IInfoSourceRepository { }
    public partial class InventoryRepository : Repository<Inventory>, IInventoryRepository { }
    public partial class ItemStatusRepository : Repository<ItemStatus>, IItemStatusRepository { }
    public partial class LeadTimeRepository : Repository<LeadTime>, ILeadTimeRepository { }
    public partial class MemberRepository : Repository<Member>, IMemberRepository { }
    public partial class MemberRoleRepository : Repository<MemberRole>, IMemberRoleRepository { }
    public partial class NeckLineRepository : Repository<NeckLine>, INeckLineRepository { }
    public partial class NoteRepository : Repository<Note>, INoteRepository { }
    public partial class PaymentTypeRepository : Repository<PaymentType>, IPaymentTypeRepository { }
    public partial class PurchaseOrderRepository : Repository<PurchaseOrder>, IPurchaseOrderRepository { }
    public partial class PurchaseOrderDetailRepository : Repository<PurchaseOrderDetail>, IPurchaseOrderDetailRepository { }
    public partial class PurchaseStatusRepository : Repository<PurchaseStatus>, IPurchaseStatusRepository { }
    public partial class ReportMessageRepository : Repository<ReportMessage>, IReportMessageRepository { }
    public partial class SchoolRepository : Repository<School>, ISchoolRepository { }
    public partial class SecurityLevelRepository : Repository<SecurityLevel>, ISecurityLevelRepository { }
    public partial class SilhouetteRepository : Repository<Silhouette>, ISilhouetteRepository { }
    public partial class SizeRangeRepository : Repository<SizeRange>, ISizeRangeRepository { }
    public partial class SleeveRepository : Repository<Sleeve>, ISleeveRepository { }
    public partial class StyleColorRepository : Repository<StyleColor>, IStyleColorRepository { }
    public partial class StyleColorNameListRepository : Repository<StyleColorNameList>, IStyleColorNameListRepository { }
    public partial class StyleFormatRepository : Repository<StyleFormat>, IStyleFormatRepository { }
    public partial class StyleMasterRepository : Repository<StyleMaster>, IStyleMasterRepository { }
    public partial class SysParameterRepository : Repository<SysParameter>, ISysParameterRepository { }
    public partial class TicketRepository : Repository<Ticket>, ITicketRepository { }
    public partial class TicketDetailRepository : Repository<TicketDetail>, ITicketDetailRepository { }
    public partial class TransactionTypeRepository : Repository<TransactionType>, ITransactionTypeRepository { }
    public partial class VendorRepository : Repository<Vendor>, IVendorRepository { }
}
