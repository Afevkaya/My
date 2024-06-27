using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ChangePortfolioModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PorjectUrl",
                table: "Porfolios",
                newName: "ProjectUrl");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Porfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Porfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Porfolios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Porfolios");

            migrationBuilder.RenameColumn(
                name: "ProjectUrl",
                table: "Porfolios",
                newName: "PorjectUrl");
        }
    }
}
