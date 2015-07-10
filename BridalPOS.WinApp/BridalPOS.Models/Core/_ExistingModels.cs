//------------------------------------------------------------------------------
// <Notes>
//    This code was generated from the existing database.
//    All other models created later must be written in different class files    
//    All models should inherit Modelbase
//    [GOURAB 10-Jul-2015]
// </Notes>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridalPOS.Models.Base;
using System;

namespace BridalPOS.Models.Core
{
    public class Action : ModelBase             
    {
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> CompleteDate { get; set; }
        public string Note { get; set; }

        public virtual Employee Clerk { get; set; }
        public virtual Member Member { get; set; }
    }
    public class CashDrawer : ModelBase         
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime PostDate { get; set; }
        public bool IsArchive { get; set; }

        public virtual PaymentType PaymentType { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
    public class Class : ModelBase              
    {
        public Class()
        {
            this.Favorites = new HashSet<Favorite>();
            this.LeadTimes = new HashSet<LeadTime>();
            this.StyleMasters = new HashSet<StyleMaster>();
        }

        public string Name { get; set; }
        public Nullable<double> MakeupPercent { get; set; }
        public Nullable<decimal> MakeupPrice { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<LeadTime> LeadTimes { get; set; }
        public virtual ICollection<StyleMaster> StyleMasters { get; set; }
    }
    public class Color : ModelBase              
    {
        public Color()
        {
            this.Favorites = new HashSet<Favorite>();
            this.Inventories = new HashSet<Inventory>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
    public class ColorNameList : ModelBase      
    {

        public string Name { get; set; }
    }
    public class ColorNameListColor : ModelBase 
    {

        public Nullable<int> ColorNameListKey { get; set; }
        public Nullable<int> ColorKey { get; set; }
    }
    public class Commission : ModelBase         
    {

        public decimal Amount { get; set; }
        public bool IsPayable { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual TicketDetail TicketDetail { get; set; }
    }
    public class Employee : ModelBase           
    {
        public Employee()
        {
            this.Actions = new HashSet<Action>();
            this.Commissions = new HashSet<Commission>();
            this.Events = new HashSet<Event>();
            this.Notes = new HashSet<Note>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<Commission> Commissions { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
    public class Event : ModelBase              
    {

        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<short> BM { get; set; }
        public Nullable<short> GM { get; set; }
        public Nullable<short> FG { get; set; }
        public bool IsCancelled { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }

        public virtual Employee Consultant { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual Member Member { get; set; }
    }
    public class EventType : ModelBase          
    {
        public EventType()
        {
            this.Events = new HashSet<Event>();
        }

        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
    public class Fabric : ModelBase             
    {
        public Fabric()
        {
            this.StyleMasters = new HashSet<StyleMaster>();
        }

        public string Name { get; set; }

        public virtual ICollection<StyleMaster> StyleMasters { get; set; }
    }
    public class Favorite : ModelBase           
    {

        public Nullable<System.DateTime> PostDate { get; set; }
        public string Note { get; set; }

        public virtual Class Class { get; set; }
        public virtual Color Color { get; set; }
        public virtual Member Member { get; set; }
        public virtual StyleMaster StyleMaster { get; set; }
    }
    public class GeneralReport : ModelBase      
    {

        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }

        public virtual SecurityLevel SecurityLevel { get; set; }
    }
    public class InfoSource : ModelBase         
    {
        public InfoSource()
        {
            this.Members = new HashSet<Member>();
        }

        public string Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
    public class Inventory : ModelBase          
    {

        public string Size { get; set; }
        public int Quantity { get; set; }
        public int SampleQty { get; set; }
        public int LayawayQty { get; set; }
        public Nullable<System.DateTime> DateOfSample { get; set; }

        public virtual Color Color { get; set; }
        public virtual StyleMaster Style { get; set; }
    }
    public class ItemStatus : ModelBase         
    {
        public string Name { get; set; }
    }
    public class LeadTime : ModelBase           
    {

        public Nullable<short> RegLeadTime { get; set; }
        public Nullable<short> RushLeadTime { get; set; }

        public virtual Class Class { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
    public class Member : ModelBase             
    {
        public Member()
        {
            this.Actions = new HashSet<Action>();
            this.Events = new HashSet<Event>();
            this.Favorites = new HashSet<Favorite>();
            this.Member1 = new HashSet<Member>();
            this.Notes = new HashSet<Note>();
            this.Tickets = new HashSet<Ticket>();
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Cell { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public Nullable<short> GradYear { get; set; }
        public string Bust { get; set; }
        public string Waist { get; set; }
        public string Hip { get; set; }
        public string Size { get; set; }
        public string Height { get; set; }

        public virtual Member Owner { get; set; }
        public virtual MemberRole Role { get; set; }
        public virtual School School { get; set; }
        public virtual InfoSource SourceInfo { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Member> Member1 { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
    public class MemberRole : ModelBase         
    {
        public MemberRole()
        {
            this.Members = new HashSet<Member>();
        }

        public string Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
    public class NeckLine : ModelBase           
    {
        public NeckLine()
        {
            this.StyleMasters = new HashSet<StyleMaster>();
        }

        public string Name { get; set; }

        public virtual ICollection<StyleMaster> StyleMasters { get; set; }
    }
    public class Note : ModelBase               
    {

        public Nullable<System.DateTime> PostDate { get; set; }
        public string NoteText { get; set; }

        public virtual Employee Clerk { get; set; }
        public virtual Member Member { get; set; }
    }
    public class PaymentType : ModelBase        
    {
        public PaymentType()
        {
            this.CashDrawers = new HashSet<CashDrawer>();
        }

        public string Name { get; set; }

        public virtual ICollection<CashDrawer> CashDrawers { get; set; }
    }
    public class PurchaseOrder : ModelBase      
    {
        public PurchaseOrder()
        {
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }


        public string ShipVia { get; set; }
        public Nullable<System.DateTime> ReqShipDate { get; set; }
        public Nullable<System.DateTime> VendorShipDate { get; set; }
        public string VendorConf { get; set; }
        public string VendorSpokeTo { get; set; }
        public string Note { get; set; }
        public string RecPONote { get; set; }
        public System.DateTime PostedDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string VoidReason { get; set; }
        public string POName { get; set; }

        public virtual PurchaseStatus Status { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
    public class PurchaseOrderDetail : ModelBase
    {

        public short Line { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual TicketDetail TicketDetail { get; set; }
    }
    public class PurchaseStatus : ModelBase     
    {
        public PurchaseStatus()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public string Name { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
    public class ReportMessage : ModelBase      
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class School : ModelBase             
    {
        public School()
        {
            this.Members = new HashSet<Member>();
        }

        public string Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
    public class SecurityLevel : ModelBase      
    {
        public SecurityLevel()
        {
            this.GeneralReports = new HashSet<GeneralReport>();
        }

        public string Name { get; set; }

        public virtual ICollection<GeneralReport> GeneralReports { get; set; }
    }
    public class Silhouette : ModelBase         
    {
        public Silhouette()
        {
            this.StyleMasters = new HashSet<StyleMaster>();
        }

        public string Name { get; set; }

        public virtual ICollection<StyleMaster> StyleMasters { get; set; }
    }
    public class SizeRange : ModelBase          
    {
        public SizeRange()
        {
            this.StyleMasters = new HashSet<StyleMaster>();
            this.StyleMasters1 = new HashSet<StyleMaster>();
            this.StyleMasters2 = new HashSet<StyleMaster>();
        }

        public string Name { get; set; }
        public string Range { get; set; }

        public virtual ICollection<StyleMaster> StyleMasters { get; set; }
        public virtual ICollection<StyleMaster> StyleMasters1 { get; set; }
        public virtual ICollection<StyleMaster> StyleMasters2 { get; set; }
    }
    public class Sleeve : ModelBase             
    {
        public Sleeve()
        {
            this.StyleMasters = new HashSet<StyleMaster>();
        }

        public string Name { get; set; }

        public virtual ICollection<StyleMaster> StyleMasters { get; set; }
    }
    public class StyleColor : ModelBase         
    {

        public Nullable<int> StyleKey { get; set; }
        public Nullable<int> ColorKey { get; set; }
    }
    public class StyleColorNameList : ModelBase 
    {

        public int StyleKey { get; set; }
        public Nullable<int> ColorNameListKey { get; set; }
    }
    public class StyleFormat : ModelBase        
    {
        public StyleFormat()
        {
            this.SysParameters = new HashSet<SysParameter>();
        }

        public string Name { get; set; }

        public virtual ICollection<SysParameter> SysParameters { get; set; }
    }
    public class StyleMaster : ModelBase        
    {
        public StyleMaster()
        {
            this.Favorites = new HashSet<Favorite>();
            this.Inventories = new HashSet<Inventory>();
        }


        public string Code { get; set; }
        public string VendorStyle { get; set; }
        public string StoreStyle { get; set; }
        public string ShortDescr { get; set; }
        public Nullable<decimal> Charge1 { get; set; }
        public Nullable<decimal> Charge2 { get; set; }
        public Nullable<decimal> XLCharge { get; set; }
        public bool IsServiceItem { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public Nullable<decimal> CommissionPrice { get; set; }
        public Nullable<double> CommissionPercent { get; set; }
        public bool IsTax1 { get; set; }
        public bool IsTax2 { get; set; }
        public string LongDescr { get; set; }
        public bool IsReorderable { get; set; }
        public Nullable<System.DateTime> DiscDate { get; set; }
        public Nullable<short> RegLeadTime { get; set; }
        public Nullable<short> RushLeadTime { get; set; }

        public virtual Class Class { get; set; }
        public virtual Fabric Fabric { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual NeckLine NeckLine { get; set; }
        public virtual Silhouette Silhouette { get; set; }
        public virtual SizeRange SizeRange { get; set; }
        public virtual SizeRange ExtraSizeRange1 { get; set; }
        public virtual SizeRange ExtraSizeRange2 { get; set; }
        public virtual Sleeve Sleeve { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
    public class SysParameter : ModelBase       
    {
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string TempOverridePwd { get; set; }
        public string OverridePwd { get; set; }
        public Nullable<double> DiscPercentPwd { get; set; }
        public Nullable<decimal> DiscPricePwd { get; set; }
        public Nullable<double> DepositPercent { get; set; }
        public string ManagerPwd { get; set; }
        public string OwnerPwd { get; set; }
        public string TaxName1 { get; set; }
        public string TaxName2 { get; set; }
        public Nullable<double> TaxPercent1 { get; set; }
        public Nullable<double> TaxPercent2 { get; set; }
        public string ImagePath { get; set; }
        public int AutoStoreStyle { get; set; }
        public System.DateTime LastedRegisterSetup { get; set; }
        public string LogoPath { get; set; }
        public string CashRegisterStatus { get; set; }
        public Nullable<bool> BasePriceOnly { get; set; }
        public string TeamLeaderPwd { get; set; }

        public virtual StyleFormat StyleFormat { get; set; }
    }
    public class Ticket : ModelBase             
    {
        public decimal Total { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Balance { get; set; }

        public virtual Member Member { get; set; }
    }
    public class TicketDetail : ModelBase       
    {
        public TicketDetail()
        {
            this.Commissions = new HashSet<Commission>();
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        }


        public Nullable<int> ReceiptId { get; set; }
        public short TransactionTypeId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public Nullable<int> StyleId { get; set; }
        public Nullable<short> ColorId { get; set; }
        public string Size { get; set; }
        public string XL { get; set; }
        public Nullable<int> Quantity { get; set; }
        public decimal Price { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> Tax1 { get; set; }
        public Nullable<decimal> Tax2 { get; set; }
        public decimal RunningTotal { get; set; }
        public Nullable<decimal> ChangeDue { get; set; }
        public string VendorNote { get; set; }
        public string StoreNote { get; set; }
        public Nullable<short> ConsultantId1 { get; set; }
        public Nullable<short> ConsultantId2 { get; set; }
        public Nullable<short> ConsultantId3 { get; set; }
        public Nullable<short> StatusId { get; set; }
        public Nullable<short> PaymentTypeId { get; set; }
        public string CreditNumber { get; set; }
        public string PaymentRef { get; set; }
        public string Remark { get; set; }
        public Nullable<int> PurchaseOrderId { get; set; }
        public Nullable<short> RefundTypeId { get; set; }
        public bool IsStoreCredit { get; set; }
        public string StoreCheck { get; set; }
        public string StoreCheckRef { get; set; }
        public string RefundRef { get; set; }
        public Nullable<bool> IsUpdatedReceiptId { get; set; }

        public virtual ICollection<Commission> Commissions { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
    public class TransactionType : ModelBase    
    {
        public TransactionType()
        {
            this.CashDrawers = new HashSet<CashDrawer>();
        }

        public string Name { get; set; }

        public virtual ICollection<CashDrawer> CashDrawers { get; set; }
    }
    public class Vendor : ModelBase             
    {
        public Vendor()
        {
            this.LeadTimes = new HashSet<LeadTime>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.StyleMasters = new HashSet<StyleMaster>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Contact { get; set; }
        public string Manager { get; set; }
        public string ARContact { get; set; }
        public string Acc { get; set; }

        public virtual ICollection<LeadTime> LeadTimes { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<StyleMaster> StyleMasters { get; set; }
    }







}
