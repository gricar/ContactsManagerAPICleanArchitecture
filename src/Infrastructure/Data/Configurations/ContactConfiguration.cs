using Microsoft.EntityFrameworkCore;
using ContactsManagerAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactsManagerAPI.Infrastructure.Data.Configurations;
public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");

        builder.HasKey(c => c.Id);
    }
}
