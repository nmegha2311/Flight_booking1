using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticketing_RepoLayer.Migrations
{
    public partial class init2222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Flight_Number",
                table: "customer_Details",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flight_Number",
                table: "customer_Details");
        }
    }
}
