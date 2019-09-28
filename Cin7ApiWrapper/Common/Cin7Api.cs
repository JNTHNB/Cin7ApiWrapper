using Cin7ApiWrapper.Endpoints;
using Cin7ApiWrapper.Infrastructure;

namespace Cin7ApiWrapper.Common
{
    public class Cin7Api
    {
        public string UserAgent
        {
            set
            {
                client.UserAgent = value;
            }
        }

        readonly Cin7ApiClient client;

        public Cin7Api(IUser user)
        {
            client = new Cin7ApiClient(new Cin7ApiSettings(), user, new RateLimiter());

            Contacts = new ContactsEndpoint(client);
            Branches = new BranchesEndpoint(client);
            ProductCategories = new ProductCategoriesEndpoint(client);
            Products = new ProductsEndpoint(client);
            ProductOptions = new ProductOptionsEndpoint(client);
            SerialNumbers = new SerialNumbersEndpoint(client);
            SalesOrders = new SalesOrdersEndpoint(client);
            Payments = new PaymentsEndpoint(client);
            Quotes = new QuotesEndpoint(client);
            PurchaseOrders = new PurchaseOrdersEndpoint(client);
            Stock = new StockEndpoint(client);
            BranchTransfers = new BranchTransfersEndpoint(client);
            Adjustments = new AdjustmentsEndpoint(client);
            Vouchers = new VouchersEndpoint(client);
            CreditNotes = new CreditNotesEndpoint(client);
            BomMasters = new BomMastersEndpoint(client);
            ProductionJobs = new ProductionJobsEndpoint(client);
            Users = new UsersEndpoint(client);
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
