using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ApplicationDbContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }

        public DbSet<Domain.Employee> Employees { get; set; }
    }
}
