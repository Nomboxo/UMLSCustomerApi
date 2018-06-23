using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ULMSCustomerDomain.Entities;

namespace ULMSRepository.Mapping
{
    public class PostalAddressMapping : IEntityTypeConfiguration<PostalAddress>
    {
        public PostalAddressMapping(EntityTypeBuilder<PostalAddress> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("PostalAddresses");
            entityTypeBuilder.HasKey(p => p.Id);
        }

        public void Configure(EntityTypeBuilder<PostalAddress> builder)
        {
            builder.ToTable("PostalAddresses");
            builder.HasKey(p => p.Id);
        }
    }
}
