using Microsoft.EntityFrameworkCore.Migrations;

namespace GoCyclist.Migrations
{
    public partial class DestinationCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Destinations",
                newName: "RouteRating");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Destinations",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DestinationRating",
                table: "Destinations",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Route",
                table: "Destinations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationRating",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Route",
                table: "Destinations");

            migrationBuilder.RenameColumn(
                name: "RouteRating",
                table: "Destinations",
                newName: "Rating");
        }
    }
}
