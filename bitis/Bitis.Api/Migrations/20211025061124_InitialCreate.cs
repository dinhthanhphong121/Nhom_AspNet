using Microsoft.EntityFrameworkCore.Migrations;

namespace Bitis.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    IdDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.IdDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdSp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    IdDanhMuc = table.Column<int>(type: "int", nullable: false),
                    MoTaSp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiTietSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhSp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdSp);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "IdDanhMuc", "TenDanhMuc" },
                values: new object[,]
                {
                    { 1, "Giày Nam" },
                    { 2, "Giày nữ" },
                    { 3, "Giày thể thao" },
                    { 4, "Giày Tây" },
                    { 5, "Túi xách" },
                    { 6, "Phụ Kiện" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "IdSp", "ChiTietSP", "Gia", "HinhSp", "IdDanhMuc", "MaSp", "MoTaSp", "SoLuong", "TenSp" },
                values: new object[,]
                {
                    { 1, "là 1 thương hiêu nổi tieeng", 100000, "asset/img/sp1.jpg", 1, "aaasss", "adshjklahbjjkd", 100, "giày nam" },
                    { 2, "là 1 thương hiêu nổi tieeng", 120000, "asset/img/sp2.jpg", 2, "a", "a", 100, "giày nam đế cao" },
                    { 3, "là 1 thương hiêu nổi tieeng", 200000, "asset/img/sp3.jpg", 1, "sss", "adsđa", 200, "giày nu " },
                    { 4, "là 1 thương hiêu nổi tieeng", 2030000, "asset/img/sp4.jpg", 3, "sssccccs", "adsdfđfgfdfggfghnghjhghjjyhjjhđa", 200, "giày nu ssssdsfs" },
                    { 5, "là 1 thương hiêu nổi tieeng", 200000, "asset/img/sp5.jpg", 4, "p", "adsđa", 200, "phụ kiện " },
                    { 6, "là 1 thương hiêu nổi tieeng", 200000, "asset/img/sp6.jpg", 1, "faaffafaf", "adsđa", 200, "túi sahs " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
