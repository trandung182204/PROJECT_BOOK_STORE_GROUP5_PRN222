using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Migrations
{
    public partial class AddPaymentFieldsAndCartEnhancements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 🛒 CART ITEMS: thêm UnitPrice
            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "cart_items", // 👈 sửa tên bảng cho đúng với SQL Server
                type: "decimal(10,2)",
                nullable: true);

            // 🧾 ORDERS: thêm các cột thanh toán và địa chỉ giao hàng
            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Orders",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Orders",
                type: "nvarchar(20)",
                nullable: true,
                defaultValue: "PENDING");

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Orders",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress",
                table: "Orders",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Orders",
                type: "nvarchar(255)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Rollback nếu cần
            migrationBuilder.DropColumn(name: "UnitPrice", table: "cart_items"); // 👈 sửa ở đây luôn

            migrationBuilder.DropColumn(name: "PaymentMethod", table: "Orders");
            migrationBuilder.DropColumn(name: "PaymentStatus", table: "Orders");
            migrationBuilder.DropColumn(name: "TransactionId", table: "Orders");
            migrationBuilder.DropColumn(name: "PaymentDate", table: "Orders");
            migrationBuilder.DropColumn(name: "ShippingAddress", table: "Orders");
            migrationBuilder.DropColumn(name: "Note", table: "Orders");
        }
    }
}
