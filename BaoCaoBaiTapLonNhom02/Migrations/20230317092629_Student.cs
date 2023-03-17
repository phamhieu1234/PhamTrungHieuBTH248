using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaoCaoBaiTapLonNhom02.Migrations
{
    /// <inheritdoc />
    public partial class Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cathi",
                columns: table => new
                {
                    MaCathi = table.Column<string>(type: "TEXT", nullable: false),
                    ThoigianCathi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cathi", x => x.MaCathi);
                });

            migrationBuilder.CreateTable(
                name: "Nhom",
                columns: table => new
                {
                    MaNhom = table.Column<string>(type: "TEXT", nullable: false),
                    TenNhom = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhom", x => x.MaNhom);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    MaID = table.Column<string>(type: "TEXT", nullable: false),
                    Ten = table.Column<string>(type: "TEXT", nullable: false),
                    MaNhom = table.Column<string>(type: "TEXT", nullable: false),
                    MaCathi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.MaID);
                    table.ForeignKey(
                        name: "FK_Student_Cathi_MaCathi",
                        column: x => x.MaCathi,
                        principalTable: "Cathi",
                        principalColumn: "MaCathi");
                    table.ForeignKey(
                        name: "FK_Student_Nhom_MaNhom",
                        column: x => x.MaNhom,
                        principalTable: "Nhom",
                        principalColumn: "MaNhom",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_MaCathi",
                table: "Student",
                column: "MaCathi");

            migrationBuilder.CreateIndex(
                name: "IX_Student_MaNhom",
                table: "Student",
                column: "MaNhom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Cathi");

            migrationBuilder.DropTable(
                name: "Nhom");
        }
    }
}
