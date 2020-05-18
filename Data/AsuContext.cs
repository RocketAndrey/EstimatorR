﻿using Estimator.Models;
using Estimator.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Estimator.Data
{
    public class AsuContext : DbContext
    {
        public AsuContext(DbContextOptions<AsuContext> options)
            : base(options)
        {
        }
        public DbSet<Estimator.Models.AsuViews.TestedType> TestedTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().ToTable("Customer");
           
    }
  
    }
}