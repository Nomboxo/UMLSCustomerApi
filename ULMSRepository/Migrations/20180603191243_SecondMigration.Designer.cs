﻿// <auto-generated />
using LookUps.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ULMSRepository.Context;

namespace ULMSRepository.Migrations
{
    [DbContext(typeof(ULMSCustomerContext))]
    [Migration("20180603191243_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ULMSCustomerDomain.Entities.CellPhoneNumbers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("MondifiedBy");

                    b.Property<string>("Number");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CellPhoneNumbers");
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<int>("CustomerType");

                    b.Property<string>("FirstName");

                    b.Property<string>("Message");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("MondifiedBy");

                    b.Property<string>("Ocupation");

                    b.Property<int?>("PostalAddressId");

                    b.Property<int>("StatusCode");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("PostalAddressId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.EmailAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("Address");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("MondifiedBy");

                    b.HasKey("Id");

                    b.ToTable("EmailAddress");
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.PostalAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("City");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Line1");

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("MondifiedBy");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("PostalAddresses");
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.ResidentialAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("City");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Line1");

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<string>("MondifiedBy");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("ResidentialAddresses");
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.CellPhoneNumbers", b =>
                {
                    b.HasOne("ULMSCustomerDomain.Entities.Customer")
                        .WithMany("CellPhoneNumbers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.Customer", b =>
                {
                    b.HasOne("ULMSCustomerDomain.Entities.ResidentialAddress", "PostalAddress")
                        .WithMany()
                        .HasForeignKey("PostalAddressId");
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.PostalAddress", b =>
                {
                    b.HasOne("ULMSCustomerDomain.Entities.Customer")
                        .WithMany("EmailAddress")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ULMSCustomerDomain.Entities.ResidentialAddress", b =>
                {
                    b.HasOne("ULMSCustomerDomain.Entities.Customer", "Customer")
                        .WithOne("ResidentialAddress")
                        .HasForeignKey("ULMSCustomerDomain.Entities.ResidentialAddress", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
