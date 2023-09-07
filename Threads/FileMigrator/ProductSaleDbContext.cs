using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMigrator
{
    public class ProductSaleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MyWarehouse3;Trusted_Connection=True;TrustServerCertificate=Yes");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var productSale = modelBuilder.Entity<ProductSale>();
            productSale.HasKey(s => s.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
