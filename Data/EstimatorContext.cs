using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Estimator.Models;

namespace Estimator.Data
{
    public class EstimatorContext : DbContext
    {
        public EstimatorContext (DbContextOptions<EstimatorContext> options)
            : base(options)
        {
        }

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
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<ClassECB>().ToTable("ClassECB");
            modelBuilder.Entity<CustomerRequest>().ToTable("CustomerRequests");
            modelBuilder.Entity<ElementType>().ToTable("ElementType");
            modelBuilder.Entity<Operation>().ToTable("Operation");
            modelBuilder.Entity<TestProgram>().ToTable("TestProgram");

            //Добавляем цепочки испытаний (миграция AddTestChains)
          
            modelBuilder.Entity<TestAction>().ToTable("TestAction");
            modelBuilder.Entity<Qualification>().ToTable("Qualification");
            
            modelBuilder.Entity<TestChainItem>().ToTable("TestChainItem");
            modelBuilder.Entity<RequestElementType>().ToTable("RequestElementType");


        }
    }
}
