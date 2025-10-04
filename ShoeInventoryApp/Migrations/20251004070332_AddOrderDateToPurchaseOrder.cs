using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoeInventoryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderDateToPurchaseOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoeColorVariations_PurchaseOrders_PurchaseOrderId",
                table: "ShoeColorVariations");

            migrationBuilder.DropIndex(
                name: "IX_ShoeColorVariations_PurchaseOrderId",
                table: "ShoeColorVariations");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderId",
                table: "ShoeColorVariations");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "PurchaseOrders",
                newName: "TotalAmount");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "PurchaseOrders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "PurchaseOrders");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "PurchaseOrders",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderId",
                table: "ShoeColorVariations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ShoeColorVariations",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseOrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ShoeColorVariations",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseOrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ShoeColorVariations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseOrderId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ShoeColorVariations",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseOrderId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ShoeColorVariations_PurchaseOrderId",
                table: "ShoeColorVariations",
                column: "PurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoeColorVariations_PurchaseOrders_PurchaseOrderId",
                table: "ShoeColorVariations",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrders",
                principalColumn: "Id");
        }
    }
}
