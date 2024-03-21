using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStore.Data.Migrations
{
    public partial class NewPropertiesForMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieApplication",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovieInvitation",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MovieRoles",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieApplication",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieInvitation",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieRoles",
                table: "Movies");
        }
    }
}
