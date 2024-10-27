using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanningApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTouristSpotPopularityCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "IsPopular",
                table: "TouristSpots",
                newName: "PopularityCount");

            migrationBuilder.AddColumn<string>(
                name: "Favorites",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "Users",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favorites",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PopularityCount",
                table: "TouristSpots",
                newName: "IsPopular");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
