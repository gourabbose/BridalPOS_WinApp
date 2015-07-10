using BridalPOS.Models.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridalPOS.DataAccess
{
    public class BridalPOSContext : DbContext
    {
        public BridalPOSContext()
            : base("name=BridalPOSEntities")
        {
        }
        
        public DbSet<BridalPOS.Models.Core.Action> Actions { get; set; }
        public DbSet<CashDrawer> CashDrawers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ColorNameList> ColorNameLists { get; set; }
        public DbSet<ColorNameListColor> ColorNameListColors { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Fabric> Fabrics { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<GeneralReport> GeneralReports { get; set; }
        public DbSet<InfoSource> InfoSources { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<ItemStatus> ItemStatus { get; set; }
        public DbSet<LeadTime> LeadTimes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberRole> MemberRoles { get; set; }
        public DbSet<NeckLine> NeckLines { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<PurchaseStatus> PurchaseStatus { get; set; }
        public DbSet<ReportMessage> ReportMessages { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SecurityLevel> SecurityLevels { get; set; }
        public DbSet<Silhouette> Silhouettes { get; set; }
        public DbSet<SizeRange> SizeRanges { get; set; }
        public DbSet<Sleeve> Sleeves { get; set; }
        public DbSet<StyleColor> StyleColors { get; set; }
        public DbSet<StyleColorNameList> StyleColorNameLists { get; set; }
        public DbSet<StyleFormat> StyleFormats { get; set; }
        public DbSet<StyleMaster> StyleMasters { get; set; }
        public DbSet<SysParameter> SysParameters { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketDetail> TicketDetails { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
