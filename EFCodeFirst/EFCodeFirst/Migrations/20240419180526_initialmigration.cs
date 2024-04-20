using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirst.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    KhoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lops_khoas_KhoaId",
                        column: x => x.KhoaId,
                        principalTable: "khoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sinhViens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Tuoi = table.Column<int>(nullable: false),
                    LopId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sinhViens_lops_LopId",
                        column: x => x.LopId,
                        principalTable: "lops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lops_KhoaId",
                table: "lops",
                column: "KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_sinhViens_LopId",
                table: "sinhViens",
                column: "LopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sinhViens");

            migrationBuilder.DropTable(
                name: "lops");

            migrationBuilder.DropTable(
                name: "khoas");
        }
    }
}
