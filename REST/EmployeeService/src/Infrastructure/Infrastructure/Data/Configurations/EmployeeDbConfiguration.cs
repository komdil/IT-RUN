using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class EmployeeDbConfiguration : IEntityTypeConfiguration<Domain.Employee>
    {
        public void Configure(EntityTypeBuilder<Domain.Employee> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
