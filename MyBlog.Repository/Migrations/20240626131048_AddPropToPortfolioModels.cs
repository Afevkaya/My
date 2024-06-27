﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddPropToPortfolioModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Porfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Porfolios");
        }
    }
}
