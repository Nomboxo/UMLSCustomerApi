using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ULMSCustomerDomain.Entities;

namespace ULMSRepository.Mapping
{
    public class ResidentialAddressMapping : IEntityTypeConfiguration<ResidentialAddress>
    {
        public ResidentialAddressMapping(EntityTypeBuilder<ResidentialAddress> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("ResidentialAddresses");
            entityTypeBuilder.HasKey(x => x.Id);
        }

        public void Configure(EntityTypeBuilder<ResidentialAddress> builder)
        {
            builder.ToTable("ResidentialAddresses");
            builder.HasKey(x => x.Id);

        }
    }
}
