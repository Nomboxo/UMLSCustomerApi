using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ULMSCustomerDomain.Entities;

namespace ULMSRepository.Mapping
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public CustomerMapping(EntityTypeBuilder<Customer> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Customers");
            entityTypeBuilder.HasKey(x => x.Id);
        }

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.Id);
        }
    }
}
