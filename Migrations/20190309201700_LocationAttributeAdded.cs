using Microsoft.EntityFrameworkCore.Migrations;

namespace GoCyclist.Migrations
{
    public partial class LocationAttributeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Destinations",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Destinations",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Destinations");
        }
    }
}
