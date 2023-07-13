using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
namespace Infrastructure.Data.Configurations
{
    public class ContactDbConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(s => s.Users).WithOne(x => x.Contact)
                .HasForeignKey(s => s.ContactId);
        }
    }
}
