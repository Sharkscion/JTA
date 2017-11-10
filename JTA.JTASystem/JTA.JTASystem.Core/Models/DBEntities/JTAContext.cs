
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JTA.JTASystem.Core
{
    public class JTAContext : DbContext
    {

        public JTAContext()  : base("JTADbConn")
        {
           Database.SetInitializer<JTAContext>(new CreateDatabaseIfNotExists<JTAContext>());  

        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Barangay> Barangays { get; set; }
        public virtual DbSet<CityMunicipality> CityMunicipalities { get; set; }
        public virtual DbSet<ContactInformation> ContactInformations { get; set; }
        public virtual DbSet<CreditRating>  CreditRatings { get; set; }
        public virtual DbSet<Customer>  Customers { get; set; }
        public virtual DbSet<CustomerBlockedProduct> CustomerBlockedProducts { get; set; }
        public virtual DbSet<CustomerBranch>  CustomerBranches{ get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Employee> Employees{ get; set; }
        public virtual DbSet<OrderDetail> OrderDetails  { get; set; }
        public virtual DbSet<Person> Persons  { get; set; }
        public virtual DbSet<PersonType> PersonTypes  { get; set; }
        public virtual DbSet<PriceUpdate> PriceUpdates  { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories  { get; set; }
        public virtual DbSet<ProductDiscount> ProductDiscounts  { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants  { get; set; }
        public virtual DbSet<Province> Provinces  { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Region> Regions  { get; set; }
        public virtual DbSet<Route> Routes  { get; set; }
        public virtual DbSet<Supplier> Suppliers  { get; set; }
        public virtual DbSet<User> Users  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Document>()
            //    .HasRequired(c => c.IssuedBy)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Document>()
            //   .HasRequired(s => s.SalesPerson)
            //   .WithMany()
            //   .WillCascadeOnDelete(false);

            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}
