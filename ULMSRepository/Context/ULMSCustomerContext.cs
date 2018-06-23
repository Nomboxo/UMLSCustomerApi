using Microsoft.EntityFrameworkCore;
using ULMSCustomerDomain.Entities;
using ULMSRepository.Mapping;

namespace ULMSRepository.Context
{
    public class ULMSCustomerContext : DbContext
    {
        public ULMSCustomerContext(DbContextOptions<ULMSCustomerContext> options) :
            base(options)
        {

        }

        public ULMSCustomerContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: Move this to the confif file.
            string cn = @"Server=MANE2\MANELISI;Database=ULMSCustomer;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(cn);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CellPhoneNumbers> CellPhoneNumbers { get; set; }
        public DbSet<PostalAddress> PostalAddresses { get; set; }
        public DbSet<ResidentialAddress> ResidentialAddresses { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
            .HasOne(a => a.ResidentialAddress)
            .WithOne(b => b.Customer)
            .HasForeignKey<ResidentialAddress>(b => b.CustomerId);

           // modelBuilder.Entity<Customer>().Property(c => c.ResidentialAddress).IsRequired();

            new CustomerMapping (modelBuilder.Entity<Customer>());
            new ResidentialAddressMapping(modelBuilder.Entity<ResidentialAddress>());
            new CellPhoneNumbersMapping(modelBuilder.Entity<CellPhoneNumbers>());
            new PostalAddressMapping(modelBuilder.Entity<PostalAddress>());
            new EmailAddressMapping(modelBuilder.Entity<EmailAddress>());
        }
    }
}