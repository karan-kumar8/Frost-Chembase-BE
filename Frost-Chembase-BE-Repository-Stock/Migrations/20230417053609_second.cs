using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frost_Chembase_BE_Repository_Stock.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Masters_Categories_CategoryId",
                table: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_Masters_CategoryId",
                table: "Masters");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Masters");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "MainCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MainCategories_CategoryId",
                table: "MainCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainCategories_Categories_CategoryId",
                table: "MainCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainCategories_Categories_CategoryId",
                table: "MainCategories");

            migrationBuilder.DropIndex(
                name: "IX_MainCategories_CategoryId",
                table: "MainCategories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "MainCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Masters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Masters_CategoryId",
                table: "Masters",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Masters_Categories_CategoryId",
                table: "Masters",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
