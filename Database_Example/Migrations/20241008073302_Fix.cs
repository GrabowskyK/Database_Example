using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Example.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FlashCards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FavouriteUsersWord");

            migrationBuilder.DropColumn(
                name: "WordId",
                table: "FavouriteUsersWord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FlashCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FavouriteUsersWord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WordId",
                table: "FavouriteUsersWord",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
