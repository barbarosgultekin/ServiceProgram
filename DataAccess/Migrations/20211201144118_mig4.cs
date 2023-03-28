using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Genders");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Genders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Genders");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Genders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
