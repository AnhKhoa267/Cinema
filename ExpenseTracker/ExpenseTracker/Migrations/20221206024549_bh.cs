using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    public partial class bh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CauThus",
                columns: table => new
                {
                    IdCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SoAo = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauThus", x => x.IdCT);
                });

            migrationBuilder.CreateTable(
                name: "DoiBongs",
                columns: table => new
                {
                    MADOIBONG = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENQUOCGIA = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SOCAUTHU = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    HLV = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoiBongs", x => x.MADOIBONG);
                });

            migrationBuilder.CreateTable(
                name: "Lichs",
                columns: table => new
                {
                    LichId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDoi1 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TenDoi2 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SAN = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lichs", x => x.LichId);
                });

            migrationBuilder.InsertData(
                table: "CauThus",
                columns: new[] { "IdCT", "SoAo", "Ten", "Type", "ViTri" },
                values: new object[] { 1, "10", "LIONEL MESSI", "Chinh", "TienVe" });

            migrationBuilder.InsertData(
                table: "CauThus",
                columns: new[] { "IdCT", "SoAo", "Ten", "Type", "ViTri" },
                values: new object[] { 2, "7", "CRISTIANO RONALDO", "Chinh", "TienVe" });

            migrationBuilder.InsertData(
                table: "CauThus",
                columns: new[] { "IdCT", "SoAo", "Ten", "Type", "ViTri" },
                values: new object[] { 3, "9", "CT-003", "Chinh", "TienVe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CauThus");

            migrationBuilder.DropTable(
                name: "DoiBongs");

            migrationBuilder.DropTable(
                name: "Lichs");
        }
    }
}
