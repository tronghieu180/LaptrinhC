using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirst.Migrations
{
    public partial class themdulieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "khoas",
                columns: new[] { "Id", "Ten" },
                values: new object[] { 2, "XayDung" });

            migrationBuilder.InsertData(
                table: "lops",
                columns: new[] { "Id", "KhoaId", "Ten" },
                values: new object[] { 2, 2, "Lop2" });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "Id", "LopId", "Ten", "Tuoi" },
                values: new object[] { 2, 2, "SinhVien2", 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "lops",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "khoas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
