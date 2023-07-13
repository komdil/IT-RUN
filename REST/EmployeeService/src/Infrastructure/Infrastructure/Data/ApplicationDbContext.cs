using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ApplicationDbContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }

        public DbSet<Domain.Employee> Employees { get; set; }
        public DbSet<Domain.Contact> Contact { get; set; }
    }
}
