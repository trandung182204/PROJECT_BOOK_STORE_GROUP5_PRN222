using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Migrations
{
    public partial class AddPaymentFieldsAndCartEnhancements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Thêm UnitPrice vào cart_items nếu chưa có
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'UnitPrice' AND Object_ID = Object_ID('dbo.cart_items'))
BEGIN
    ALTER TABLE [dbo].[cart_items] ADD [UnitPrice] DECIMAL(10,2) NULL;
END
");

            // Thêm TransactionId nếu chưa có (snake_case trong DB là transaction_id; kiểm tra cả 2 dạng)
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'transaction_id' AND Object_ID = Object_ID('dbo.orders'))
AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'TransactionId' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] ADD [transaction_id] NVARCHAR(100) NULL;
END
");

            // Thêm payment_date nếu chưa có
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'payment_date' AND Object_ID = Object_ID('dbo.orders'))
AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'PaymentDate' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] ADD [payment_date] DATETIME2 NULL;
END
");

            // Thêm note nếu chưa có
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'note' AND Object_ID = Object_ID('dbo.orders'))
AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'Note' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] ADD [note] NVARCHAR(255) NULL;
END
");

            // Nếu bạn muốn thêm shipping_address (nhiều DB của bạn đã có), chỉ thêm khi thiếu
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'shipping_address' AND Object_ID = Object_ID('dbo.orders'))
AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'ShippingAddress' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] ADD [shipping_address] NVARCHAR(MAX) NULL;
END
");

            // Nếu muốn thêm payment_status default, nhưng DB có thể đã có payment_status.
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'payment_status' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] ADD [payment_status] NVARCHAR(20) NULL CONSTRAINT DF_orders_payment_status DEFAULT 'PENDING';
END
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Rollback: xóa các cột chỉ khi tồn tại
            migrationBuilder.Sql(@"
IF EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'UnitPrice' AND Object_ID = Object_ID('dbo.cart_items'))
BEGIN
    ALTER TABLE [dbo].[cart_items] DROP COLUMN [UnitPrice];
END
");

            migrationBuilder.Sql(@"
IF EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'transaction_id' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] DROP COLUMN [transaction_id];
END
");

            migrationBuilder.Sql(@"
IF EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'payment_date' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] DROP COLUMN [payment_date];
END
");

            migrationBuilder.Sql(@"
IF EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'note' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] DROP COLUMN [note];
END
");

            migrationBuilder.Sql(@"
IF EXISTS (SELECT 1 FROM sys.columns WHERE Name = 'shipping_address' AND Object_ID = Object_ID('dbo.orders'))
BEGIN
    ALTER TABLE [dbo].[orders] DROP COLUMN [shipping_address];
END
");
        }
    }
}
