using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Example.Migrations
{
    /// <inheritdoc />
    public partial class AddUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "FlashCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "FlashCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FlashCards_UsersId",
                table: "FlashCards",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlashCards_User_UsersId",
                table: "FlashCards",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlashCards_User_UsersId",
                table: "FlashCards");

            migrationBuilder.DropIndex(
                name: "IX_FlashCards_UsersId",
                table: "FlashCards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FlashCards");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "FlashCards");
        }
    }
}
