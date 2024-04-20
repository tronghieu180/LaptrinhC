using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirst.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sinhViens_lops_LopId",
                table: "sinhViens");

            migrationBuilder.InsertData(
                table: "khoas",
                columns: new[] { "Id", "Ten" },
                values: new object[] { 1, "CNTT" });

            migrationBuilder.InsertData(
                table: "lops",
                columns: new[] { "Id", "KhoaId", "Ten" },
                values: new object[] { 1, 1, "Lop1" });

            migrationBuilder.InsertData(
                table: "sinhViens",
                columns: new[] { "Id", "LopId", "Ten", "Tuoi" },
                values: new object[] { 1, 1, "SinhVien1", 20 });

            migrationBuilder.AddForeignKey(
                name: "FK_sinhViens_lops_LopId",
                table: "sinhViens",
                column: "LopId",
                principalTable: "lops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sinhViens_lops_LopId",
                table: "sinhViens");

            migrationBuilder.DeleteData(
                table: "sinhViens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "lops",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "khoas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_sinhViens_lops_LopId",
                table: "sinhViens",
                column: "LopId",
                principalTable: "lops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
