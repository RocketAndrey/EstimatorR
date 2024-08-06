using Estimator.Models;
using Estimator.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Estimator.Data
{
    public class EstimatorContext : DbContext
    {
        public EstimatorContext(DbContextOptions<EstimatorContext> options)
            : base(options)
        {
           // Database.EnsureCreated();//
        }
        public DbSet<Estimator.Models.Price> Prices { get; set; }
        public DbSet<Estimator.Models.PriceList> PriceLists { get; set; }
        public DbSet<Estimator.Models.RuChipsDB> DirVniir { get; set; }
        public DbSet<Estimator.Models.Company> Companies { get; set; }
        public DbSet<Estimator.Models.ImFileData> ImportData { get; set; }
        public DbSet<Estimator.Models.Customer> Customers { get; set; }
        public DbSet<Estimator.Models.ClassECB> ClassECBs { get; set; }
        public DbSet<Estimator.Models.CustomerRequest> CustomerRequests { get; set; }
        public DbSet<Estimator.Models.ElementType> ElementTypes { get; set; }
        public DbSet<Estimator.Models.Operation> Operations { get; set; }
        public DbSet<Estimator.Models.TestProgram> TestPrograms { get; set; }

        //Добавляем цепочки испытаний
        public DbSet<Estimator.Models.TestAction> TestActions { get; set; }

        public DbSet<Estimator.Models.Qualification> Qualifications { get; set; }
        public DbSet<Estimator.Models.TestChainItem> TestChainItems { get; set; }
        public DbSet<Estimator.Models.RequestElementType> RequestElementTypes { get; set; }
        public DbSet<Estimator.Models.ViewModels.RequestOperationGroupView> RequestOperationGroupViews { get; set; }
        public DbSet<Estimator.Models.OperationGroup> OperationGroups { get; set; }
        public DbSet<Estimator.Models.CompanyHistory> CompanyHistories { get; set; }
        public DbSet<Estimator.Models.StaffItem> Staff { get; set; }

        public DbSet<Estimator.Models.CalcFactor> CalcFactors { get; set; }
        public DbSet <Estimator.Models.XLSXElementType> XLSXElementTypes { get; set; }
        public DbSet<Estimator.Models.ElementPriceHistory> ElementPriceHistory { get; set; }
        public DbSet<Estimator.Models.PriceItemType> PriceItemType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<ClassECB>().ToTable("ClassECB");
            modelBuilder.Entity<CustomerRequest>().ToTable("CustomerRequests");
            modelBuilder.Entity<ElementType>().ToTable("ElementType");
            modelBuilder.Entity<Operation>().ToTable("Operation");
            modelBuilder.Entity<TestProgram>().ToTable("TestProgram");

            //Добавляем цепочки испытаний (миграция AddTestChains)

            modelBuilder.Entity<TestAction>().ToTable("TestAction");
            modelBuilder.Entity<RequestOperationGroupView>().HasNoKey();

            modelBuilder.Entity<Qualification>().ToTable("Qualification");

            modelBuilder.Entity<TestChainItem>().ToTable("TestChainItem");
            modelBuilder.Entity<RequestElementType>().ToTable("RequestElementType");
            modelBuilder.Entity<RequestOperation>().ToTable("RequestOperation");
            modelBuilder.Entity<OperationGroup>().ToTable("OperationGroup");
            modelBuilder.Entity<CompanyHistory>().ToTable("CompanyHistory");
            modelBuilder.Entity<CalcFactor>().ToTable("CalcFactor");
            modelBuilder.Entity<StaffItem>().ToTable("StaffItem");
            modelBuilder.Entity<XLSXElementType>().ToTable("XLSXElementType");
            modelBuilder.Entity<TestProgramTemplateItem>().ToTable("TestProgramTemplateItem");
            modelBuilder.Entity<TestProgramTemplate>().ToTable("TestProgramTemplate");
            modelBuilder.Entity<ElementPriceHistory>()
                .HasOne(u => u.XLSXElementType)
                .WithMany(c => c.PriceHistory)
                 .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<XLSXElementType>()
                .HasOne(u => u.VniirItem)
                .WithMany()
                .HasForeignKey(u => u.VniirItemId)
                .HasPrincipalKey(c => c.Id);
            modelBuilder.Entity<XLSXElementType>()
                .HasOne(u => u.PriceHistorySource)
                .WithMany()
                .HasForeignKey(u => u.PriceHistorySourceID)
                .HasPrincipalKey(c => c.ElementPriceHistoryID);

        }
        public DbSet<Estimator.Models.ElementImport> ElementImports { get; set; }
     
        public DbSet<Estimator.Models.TestProgramTemplate> TestProgramTemplates { get; set; }
        public DbSet<Estimator.Models.User> User { get; set; }
        public DbSet<Estimator.Models.ElementKey> ElementKey { get; set; }
    }
}
