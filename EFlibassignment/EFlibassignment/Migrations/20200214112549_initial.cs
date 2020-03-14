using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFlibassignment.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    itemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(nullable: false),
                    price = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.itemId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderdate = table.Column<DateTime>(type: "Date", nullable: true),
                    deliverydate = table.Column<DateTime>(type: "Date", nullable: true),
                    itemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Order_Item_itemId",
                        column: x => x.itemId,
                        principalTable: "Item",
                        principalColumn: "itemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_itemId",
                table: "Order",
                column: "itemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
