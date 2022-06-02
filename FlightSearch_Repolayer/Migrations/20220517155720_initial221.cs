using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightSearch_Repolayer.Migrations
{
    public partial class initial221 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Flights_header_Flight_number",
                table: "Flights");

            migrationBuilder.AlterColumn<string>(
                name: "Flight_number",
                table: "Flights",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Flights_header_Flight_number",
                table: "Flights",
                column: "Flight_number",
                principalTable: "Flights_header",
                principalColumn: "Flightno",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Flights_header_Flight_number",
                table: "Flights");

            migrationBuilder.AlterColumn<string>(
                name: "Flight_number",
                table: "Flights",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Flights_header_Flight_number",
                table: "Flights",
                column: "Flight_number",
                principalTable: "Flights_header",
                principalColumn: "Flightno",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
