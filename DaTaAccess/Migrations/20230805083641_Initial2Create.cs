using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaTaAccess.Migrations
{
    public partial class Initial2Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Costumers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "priceSum",
                table: "Costumers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Costumers");

            migrationBuilder.DropColumn(
                name: "priceSum",
                table: "Costumers");
        }
    }
}
