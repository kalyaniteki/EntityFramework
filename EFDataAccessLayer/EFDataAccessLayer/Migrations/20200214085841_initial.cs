using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    projectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pname = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.projectID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Eid = table.Column<string>(maxLength: 5, nullable: false),
                    ename = table.Column<string>(maxLength: 30, nullable: false),
                    joindate = table.Column<DateTime>(type: "Date", nullable: true),
                    designation = table.Column<string>(maxLength: 30, nullable: true),
                    salary = table.Column<decimal>(nullable: true),
                    projectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_Employee_project_projectID",
                        column: x => x.projectID,
                        principalTable: "project",
                        principalColumn: "projectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_projectID",
                table: "Employee",
                column: "projectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "project");
        }
    }
}
