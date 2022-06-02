using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticketing_RepoLayer.Migrations
{
    public partial class init222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PNR_number",
                table: "customer_Details",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PNR_number",
                table: "customer_Details");
        }
    }
}
