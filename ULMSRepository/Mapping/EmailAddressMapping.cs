using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ULMSCustomerDomain.Entities;

namespace ULMSRepository.Mapping
{
    public class EmailAddressMapping : IEntityTypeConfiguration<EmailAddress>
    {
        private EntityTypeBuilder<EmailAddress> entityTypeBuilder;

        public EmailAddressMapping(EntityTypeBuilder<EmailAddress> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("EmailAddress");
            entityTypeBuilder.HasKey(e => e.Id);
        }

        public void Configure(EntityTypeBuilder<EmailAddress> builder)
        {
            builder.ToTable("EmailAddress");
            builder.HasKey(e => e.Id);
        }
    }
}
