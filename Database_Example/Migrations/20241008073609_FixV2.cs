using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Example.Migrations
{
    /// <inheritdoc />
    public partial class FixV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_FlashCards_FlashCardId",
                table: "Word");

            migrationBuilder.AddForeignKey(
                name: "FK_Word_FlashCards_FlashCardId",
                table: "Word",
                column: "FlashCardId",
                principalTable: "FlashCards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_FlashCards_FlashCardId",
                table: "Word");

            migrationBuilder.AddForeignKey(
                name: "FK_Word_FlashCards_FlashCardId",
                table: "Word",
                column: "FlashCardId",
                principalTable: "FlashCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
