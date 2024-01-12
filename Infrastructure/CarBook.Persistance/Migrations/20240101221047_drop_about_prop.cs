using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class drop_about_prop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Abouts_AboutId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AboutId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Blogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AboutId",
                table: "Blogs",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Abouts_AboutId",
                table: "Blogs",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "AboutId");
        }
    }
}
