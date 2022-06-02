using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightSearch_Repolayer.Migrations
{
    public partial class initial21111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "isActive",
                table: "Flights_header",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Flights_header");
        }
    }
}
