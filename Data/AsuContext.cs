using Estimator.Models;
using Estimator.Models.ViewModels;
using Estimator.Models.AsuViews;
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
        public DbSet<Estimator.Models.AsuViews.DefectedType > DefectedTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 
        }
  
    }
}
