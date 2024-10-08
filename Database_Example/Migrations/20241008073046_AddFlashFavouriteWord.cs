using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Example.Migrations
{
    /// <inheritdoc />
    public partial class AddFlashFavouriteWord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_FlashCards_FlashCardsId",
                table: "Word");

            migrationBuilder.DropIndex(
                name: "IX_Word_FlashCardsId",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "FlashCardsId",
                table: "Word");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "FlashCards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "FlashCards",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FavouriteUsersWord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordId = table.Column<int>(type: "int", nullable: false),
                    WordsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteUsersWord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavouriteUsersWord_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouriteUsersWord_Word_WordsId",
                        column: x => x.WordsId,
                        principalTable: "Word",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Word_FlashCardId",
                table: "Word",
                column: "FlashCardId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteUsersWord_UsersId",
                table: "FavouriteUsersWord",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteUsersWord_WordsId",
                table: "FavouriteUsersWord",
                column: "WordsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Word_FlashCards_FlashCardId",
                table: "Word",
                column: "FlashCardId",
                principalTable: "FlashCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_FlashCards_FlashCardId",
                table: "Word");

            migrationBuilder.DropTable(
                name: "FavouriteUsersWord");

            migrationBuilder.DropIndex(
                name: "IX_Word_FlashCardId",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "FlashCards");

            migrationBuilder.AddColumn<int>(
                name: "FlashCardsId",
                table: "Word",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "FlashCards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Word_FlashCardsId",
                table: "Word",
                column: "FlashCardsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Word_FlashCards_FlashCardsId",
                table: "Word",
                column: "FlashCardsId",
                principalTable: "FlashCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
