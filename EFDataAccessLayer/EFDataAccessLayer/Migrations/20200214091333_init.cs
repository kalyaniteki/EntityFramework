using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "edate",
                table: "project",
                type: "Date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "sdate",
                table: "project",
                type: "Date",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "edate",
                table: "project");

            migrationBuilder.DropColumn(
                name: "sdate",
                table: "project");
        }
    }
}
