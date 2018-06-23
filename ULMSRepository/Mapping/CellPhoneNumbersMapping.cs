using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ULMSCustomerDomain.Entities;

namespace ULMSRepository.Mapping
{
    class CellPhoneNumbersMapping : IEntityTypeConfiguration<CellPhoneNumbers>
    {
        public CellPhoneNumbersMapping(EntityTypeBuilder<CellPhoneNumbers> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("CellPhoneNumbers");
            entityTypeBuilder.HasKey(c => c.Id);
        }

        public void Configure(EntityTypeBuilder<CellPhoneNumbers> builder)
        {
            builder.ToTable("CellPhoneNumbers");
            builder.HasKey(c => c.Id);
        }
    }
}
