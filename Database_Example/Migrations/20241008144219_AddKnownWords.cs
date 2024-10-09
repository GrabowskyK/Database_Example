using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Example.Migrations
{
    /// <inheritdoc />
    public partial class AddKnownWords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KnownWord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownWord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnownWord_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnownWord_Word_WordsId",
                        column: x => x.WordsId,
                        principalTable: "Word",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KnownWord_UsersId",
                table: "KnownWord",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_KnownWord_WordsId",
                table: "KnownWord",
                column: "WordsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnownWord");
        }
    }
}
