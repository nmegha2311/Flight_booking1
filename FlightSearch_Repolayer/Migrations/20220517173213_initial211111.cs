using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightSearch_Repolayer.Migrations
{
    public partial class initial211111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Flights");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "isActive",
                table: "Flights",
                nullable: true);
        }
    }
}
