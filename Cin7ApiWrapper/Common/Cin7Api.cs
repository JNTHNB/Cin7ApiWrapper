using Cin7ApiWrapper.Endpoints;
using Cin7ApiWrapper.Infrastructure;

namespace Cin7ApiWrapper.Common
{
    public class Cin7Api
    {
        Cin7ApiClient Client { get; }

        public Cin7Api(IUser user)
        {
            Client = new Cin7ApiClient(new Cin7ApiSettings(), user, new RateLimiter());

            Contacts = new ContactsEndpoint(Client);
            Branches = new BranchesEndpoint(Client);
            ProductCategories = new ProductCategoriesEndpoint(Client);
            Products = new ProductsEndpoint(Client);
            ProductOptions = new ProductOptionsEndpoint(Client);
            SerialNumbers = new SerialNumbersEndpoint(Client);
            SalesOrders = new SalesOrdersEndpoint(Client);
            Payments = new PaymentsEndpoint(Client);
            Quotes = new QuotesEndpoint(Client);
            PurchaseOrders = new PurchaseOrdersEndpoint(Client);
            Stock = new StockEndpoint(Client);
            BranchTransfers = new BranchTransfersEndpoint(Client);
            Adjustments = new AdjustmentsEndpoint(Client);
            Vouchers = new VouchersEndpoint(Client);
            CreditNotes = new CreditNotesEndpoint(Client);
            BomMasters = new BomMastersEndpoint(Client);
            ProductionJobs = new ProductionJobsEndpoint(Client);
            Users = new UsersEndpoint(Client);
        }

        public ContactsEndpoint Contacts { get; }
        public BranchesEndpoint Branches { get; }
        public ProductCategoriesEndpoint ProductCategories { get; }
        public ProductsEndpoint Products { get; }
        public ProductOptionsEndpoint ProductOptions { get; }
        public SerialNumbersEndpoint SerialNumbers { get; }
        public SalesOrdersEndpoint SalesOrders { get; }
        public PaymentsEndpoint Payments { get; }
        public QuotesEndpoint Quotes { get; }
        public PurchaseOrdersEndpoint PurchaseOrders { get; }
        public StockEndpoint Stock { get; }
        public BranchTransfersEndpoint BranchTransfers { get; }
        public AdjustmentsEndpoint Adjustments { get; }
        public VouchersEndpoint Vouchers { get; }
        public CreditNotesEndpoint CreditNotes { get; }
        public BomMastersEndpoint BomMasters { get; }
        public ProductionJobsEndpoint ProductionJobs { get; }
        public UsersEndpoint Users { get; }
    }
}
