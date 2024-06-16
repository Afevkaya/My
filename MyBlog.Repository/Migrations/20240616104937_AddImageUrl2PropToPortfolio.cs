using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrl2PropToPortfolio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl2",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl2",
                table: "Porfolios");
        }
    }
}
