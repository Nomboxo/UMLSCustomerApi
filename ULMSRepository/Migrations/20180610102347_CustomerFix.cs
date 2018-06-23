using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ULMSRepository.Migrations
{
    public partial class CustomerFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_ResidentialAddresses_PostalAddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_PostalAddresses_CustomerId",
                table: "PostalAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PostalAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostalAddressId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_PostalAddresses_CustomerId",
                table: "PostalAddresses",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_CustomerId",
                table: "EmailAddress",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddress_Customers_CustomerId",
                table: "EmailAddress",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddress_Customers_CustomerId",
                table: "EmailAddress");

            migrationBuilder.DropIndex(
                name: "IX_PostalAddresses_CustomerId",
                table: "PostalAddresses");

            migrationBuilder.DropIndex(
                name: "IX_EmailAddress_CustomerId",
                table: "EmailAddress");

            migrationBuilder.AddColumn<int>(
                name: "PostalAddressId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostalAddresses_CustomerId",
                table: "PostalAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PostalAddressId",
                table: "Customers",
                column: "PostalAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_ResidentialAddresses_PostalAddressId",
                table: "Customers",
                column: "PostalAddressId",
                principalTable: "ResidentialAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
