using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Migrations
{
    /// <inheritdoc />
    public partial class AddParentIdAndIsDeletedToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__book_cate__book___45BE5BA9",
                table: "book_categories");

            migrationBuilder.DropForeignKey(
                name: "FK__book_cate__categ__46B27FE2",
                table: "book_categories");

            migrationBuilder.DropForeignKey(
                name: "FK__cart_item__book___2180FB33",
                table: "cart_items");

            migrationBuilder.DropForeignKey(
                name: "FK__cart_item__cart___208CD6FA",
                table: "cart_items");

            migrationBuilder.DropForeignKey(
                name: "FK__carts__user_id__1CBC4616",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK__order_ite__book___30C33EC3",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "FK__order_ite__order__2FCF1A8A",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "FK__orders__user_id__2BFE89A6",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK__payments__order___4F47C5E3",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK__reviews__book_id__540C7B00",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "FK__reviews__user_id__55009F39",
                table: "reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK__users__3213E83F83CF44CE",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__reviews__3213E83FC6757D82",
                table: "reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK__payments__3213E83FF91DD0E9",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK__orders__3213E83F738531E8",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK__order_it__3213E83F5C6D1A1D",
                table: "order_items");

            migrationBuilder.DropPrimaryKey(
                name: "PK__categori__3213E83F3D6EB9C1",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK__carts__3213E83FA9386628",
                table: "carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK__cart_ite__3213E83F126BE46B",
                table: "cart_items");

            migrationBuilder.DropPrimaryKey(
                name: "PK__books__3213E83F67728AE1",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK__book_cat__3213E83F8E00D2F5",
                table: "book_categories");

            migrationBuilder.DropColumn(
                name: "image_url",
                table: "books");

            migrationBuilder.DropColumn(
                name: "print_type",
                table: "books");

            migrationBuilder.RenameIndex(
                name: "UQ__users__F3DBC57266717BA7",
                table: "users",
                newName: "UQ__users__F3DBC5721EAD29EB");

            migrationBuilder.RenameIndex(
                name: "UQ__users__AB6E6164C519C7E3",
                table: "users",
                newName: "UQ__users__AB6E6164B9CF8F47");

            migrationBuilder.RenameIndex(
                name: "UQ__categori__BC9D1E7CDD7A9C13",
                table: "categories",
                newName: "UQ__categori__BC9D1E7C9E5F56CE");

            migrationBuilder.RenameIndex(
                name: "UQ__books__357D4CF9E0A42EA1",
                table: "books",
                newName: "UQ__books__357D4CF97308C31E");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(NULL)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(sysutcdatetime())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<string>(
                name: "avatar_url",
                table: "users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "reviews",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(sysutcdatetime())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "reviews",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "payments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "PENDING",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "PENDING");

            migrationBuilder.AlterColumn<string>(
                name: "payment_method",
                table: "payments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "paid_at",
                table: "payments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(NULL)");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<string>(
                name: "shipping_address",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "payment_status",
                table: "orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "UNPAID",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "UNPAID");

            migrationBuilder.AlterColumn<string>(
                name: "payment_method",
                table: "orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "COD",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "COD");

            migrationBuilder.AlterColumn<string>(
                name: "order_status",
                table: "orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "PENDING",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "PENDING");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "orders",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(sysutcdatetime())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "order_items",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "order_items",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "categories",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(sysutcdatetime())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "parent_id",
                table: "categories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "carts",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(sysutcdatetime())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "carts",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "cart_items",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "cart_items",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(NULL)");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "books",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                defaultValue: "ACTIVE",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "ACTIVE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "books",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(sysutcdatetime())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "books",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "isbn",
                table: "books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "publication_year",
                table: "books",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__users__3213E83F72CD265C",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__reviews__3213E83F321C133F",
                table: "reviews",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__payments__3213E83F33F279F1",
                table: "payments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__orders__3213E83FCA8A3B67",
                table: "orders",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__order_it__3213E83FB8B6104F",
                table: "order_items",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__categori__3213E83FE19B44D3",
                table: "categories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__carts__3213E83F578BC5AC",
                table: "carts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__cart_ite__3213E83F114ACDC6",
                table: "cart_items",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__books__3213E83F4DF6C76A",
                table: "books",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__book_cat__3213E83FE0577D5F",
                table: "book_categories",
                column: "id");

            migrationBuilder.CreateTable(
                name: "activity_logs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<long>(type: "bigint", nullable: true),
                    action = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(sysutcdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__activity__3213E83F44BC0CF2", x => x.id);
                    table.ForeignKey(
                        name: "FK_activity_logs_user",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "book_images",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_id = table.Column<long>(type: "bigint", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(sysutcdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__book_ima__3213E83FC20644AB", x => x.id);
                    table.ForeignKey(
                        name: "FK_book_images_book",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inventory_logs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_id = table.Column<long>(type: "bigint", nullable: false),
                    change_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    quantity_change = table.Column<int>(type: "int", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(sysutcdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__inventor__3213E83F683E428A", x => x.id);
                    table.ForeignKey(
                        name: "FK_inventory_logs_book",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    discount_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    discount_value = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    min_order_value = table.Column<decimal>(type: "decimal(12,2)", nullable: true, defaultValue: 0m),
                    start_date = table.Column<DateOnly>(type: "date", nullable: true),
                    end_date = table.Column<DateOnly>(type: "date", nullable: true),
                    usage_limit = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    used_count = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValue: "ACTIVE"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(sysutcdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__vouchers__3213E83FC517A450", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_parent_id",
                table: "categories",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_activity_logs_user_id",
                table: "activity_logs",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_images_book_id",
                table: "book_images",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_inventory_logs_book_id",
                table: "inventory_logs",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "UQ__vouchers__357D4CF9530AC207",
                table: "vouchers",
                column: "code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_book_categories_book",
                table: "book_categories",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_categories_category",
                table: "book_categories",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_items_book",
                table: "cart_items",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_items_cart",
                table: "cart_items",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_user",
                table: "carts",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_categories_parent",
                table: "categories",
                column: "parent_id",
                principalTable: "categories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_items_book",
                table: "order_items",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_items_order",
                table: "order_items",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_user",
                table: "orders",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_order",
                table: "payments",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_book",
                table: "reviews",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_user",
                table: "reviews",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_categories_book",
                table: "book_categories");

            migrationBuilder.DropForeignKey(
                name: "FK_book_categories_category",
                table: "book_categories");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_items_book",
                table: "cart_items");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_items_cart",
                table: "cart_items");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_user",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_categories_parent",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_order_items_book",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "FK_order_items_order",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_user",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_order",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_book",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_user",
                table: "reviews");

            migrationBuilder.DropTable(
                name: "activity_logs");

            migrationBuilder.DropTable(
                name: "book_images");

            migrationBuilder.DropTable(
                name: "inventory_logs");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropPrimaryKey(
                name: "PK__users__3213E83F72CD265C",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__reviews__3213E83F321C133F",
                table: "reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK__payments__3213E83F33F279F1",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK__orders__3213E83FCA8A3B67",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK__order_it__3213E83FB8B6104F",
                table: "order_items");

            migrationBuilder.DropPrimaryKey(
                name: "PK__categori__3213E83FE19B44D3",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_parent_id",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK__carts__3213E83F578BC5AC",
                table: "carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK__cart_ite__3213E83F114ACDC6",
                table: "cart_items");

            migrationBuilder.DropPrimaryKey(
                name: "PK__books__3213E83F4DF6C76A",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK__book_cat__3213E83FE0577D5F",
                table: "book_categories");

            migrationBuilder.DropColumn(
                name: "avatar_url",
                table: "users");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "users");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "order_items");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "parent_id",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "carts");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "cart_items");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "books");

            migrationBuilder.DropColumn(
                name: "isbn",
                table: "books");

            migrationBuilder.DropColumn(
                name: "publication_year",
                table: "books");

            migrationBuilder.RenameIndex(
                name: "UQ__users__F3DBC5721EAD29EB",
                table: "users",
                newName: "UQ__users__F3DBC57266717BA7");

            migrationBuilder.RenameIndex(
                name: "UQ__users__AB6E6164B9CF8F47",
                table: "users",
                newName: "UQ__users__AB6E6164C519C7E3");

            migrationBuilder.RenameIndex(
                name: "UQ__categori__BC9D1E7C9E5F56CE",
                table: "categories",
                newName: "UQ__categori__BC9D1E7CDD7A9C13");

            migrationBuilder.RenameIndex(
                name: "UQ__books__357D4CF97308C31E",
                table: "books",
                newName: "UQ__books__357D4CF9E0A42EA1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "users",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(NULL)",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "users",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "reviews",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "payments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "PENDING",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "PENDING");

            migrationBuilder.AlterColumn<string>(
                name: "payment_method",
                table: "payments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "paid_at",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(NULL)",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "shipping_address",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "payment_status",
                table: "orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "UNPAID",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "UNPAID");

            migrationBuilder.AlterColumn<string>(
                name: "payment_method",
                table: "orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "COD",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "COD");

            migrationBuilder.AlterColumn<string>(
                name: "order_status",
                table: "orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "PENDING",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "PENDING");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "orders",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "order_items",
                type: "int",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "categories",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "carts",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "cart_items",
                type: "int",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "books",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(NULL)",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "books",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "ACTIVE",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true,
                oldDefaultValue: "ACTIVE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "books",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "(sysutcdatetime())");

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "books",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "print_type",
                table: "books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__users__3213E83F83CF44CE",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__reviews__3213E83FC6757D82",
                table: "reviews",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__payments__3213E83FF91DD0E9",
                table: "payments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__orders__3213E83F738531E8",
                table: "orders",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__order_it__3213E83F5C6D1A1D",
                table: "order_items",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__categori__3213E83F3D6EB9C1",
                table: "categories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__carts__3213E83FA9386628",
                table: "carts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__cart_ite__3213E83F126BE46B",
                table: "cart_items",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__books__3213E83F67728AE1",
                table: "books",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__book_cat__3213E83F8E00D2F5",
                table: "book_categories",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__book_cate__book___45BE5BA9",
                table: "book_categories",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__book_cate__categ__46B27FE2",
                table: "book_categories",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__cart_item__book___2180FB33",
                table: "cart_items",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__cart_item__cart___208CD6FA",
                table: "cart_items",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__carts__user_id__1CBC4616",
                table: "carts",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__order_ite__book___30C33EC3",
                table: "order_items",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__order_ite__order__2FCF1A8A",
                table: "order_items",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__orders__user_id__2BFE89A6",
                table: "orders",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__payments__order___4F47C5E3",
                table: "payments",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK__reviews__book_id__540C7B00",
                table: "reviews",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__reviews__user_id__55009F39",
                table: "reviews",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id");
        }
    }
}
