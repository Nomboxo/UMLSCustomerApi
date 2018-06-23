using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ULMSRepository.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_Customers_CustomerId",
                table: "EmailAddresses");

            migrationBuilder.DropIndex(
                name: "IX_PostalAddresses_CustomerId",
                table: "PostalAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailAddresses",
                table: "EmailAddresses");

            migrationBuilder.DropIndex(
                name: "IX_EmailAddresses_CustomerId",
                table: "EmailAddresses");

            migrationBuilder.RenameTable(
                name: "EmailAddresses",
                newName: "EmailAddress");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostalAddressId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusCode",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailAddress",
                table: "EmailAddress",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_ResidentialAddresses_PostalAddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_PostalAddresses_CustomerId",
                table: "PostalAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailAddress",
                table: "EmailAddress");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PostalAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostalAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StatusCode",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "EmailAddress",
                newName: "EmailAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailAddresses",
                table: "EmailAddresses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostalAddresses_CustomerId",
                table: "PostalAddresses",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddresses_CustomerId",
                table: "EmailAddresses",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_Customers_CustomerId",
                table: "EmailAddresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
