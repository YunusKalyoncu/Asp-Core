using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.DataAccessLayer.Migrations
{
    public partial class yenimigg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AspNetUsers");
        }
    }
}
