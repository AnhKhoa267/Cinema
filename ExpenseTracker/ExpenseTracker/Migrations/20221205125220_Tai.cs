using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    public partial class Tai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    RapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenRap = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.RapId);
                });

            migrationBuilder.CreateTable(
                name: "DSPhims",
                columns: table => new
                {
                    PhimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ThoiLuong = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DSPhims", x => x.PhimId);
                });

            migrationBuilder.CreateTable(
                name: "Lichs",
                columns: table => new
                {
                    LichId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TenRap = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Giocongchieu = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lichs", x => x.LichId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RapId = table.Column<int>(type: "int", nullable: false),
                    CategoryRapId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(75)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_Categories_CategoryRapId",
                        column: x => x.CategoryRapId,
                        principalTable: "Categories",
                        principalColumn: "RapId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "RapId", "DiaChi", "TenRap", "Type" },
                values: new object[] { 1, "639", "AnDuongVuong", "Expense" });

            migrationBuilder.InsertData(
                table: "DSPhims",
                columns: new[] { "PhimId", "TenPhim", "ThoiLuong", "Type" },
                values: new object[] { 1, "AnDuongVuong", "639", "Expense" });

            migrationBuilder.InsertData(
                table: "Lichs",
                columns: new[] { "LichId", "Giocongchieu", "TenPhim", "TenRap", "Type" },
                values: new object[] { 1, "113h00", "AnDuongVuong", "NhaHan", "Expense" });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CategoryRapId",
                table: "Transactions",
                column: "CategoryRapId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DSPhims");

            migrationBuilder.DropTable(
                name: "Lichs");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
