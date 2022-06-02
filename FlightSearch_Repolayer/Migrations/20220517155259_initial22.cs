using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightSearch_Repolayer.Migrations
{
    public partial class initial22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights_header",
                columns: table => new
                {
                    Flightno = table.Column<string>(nullable: false),
                    Airline = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights_header", x => x.Flightno);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    From_Place = table.Column<string>(nullable: true),
                    To_Place = table.Column<string>(nullable: true),
                    Startdatetime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    Scheduledays = table.Column<string>(nullable: true),
                    Instrumentused = table.Column<string>(nullable: true),
                    Business = table.Column<int>(nullable: false),
                    non_business = table.Column<int>(nullable: false),
                    cost = table.Column<int>(nullable: false),
                    rows = table.Column<int>(nullable: false),
                    meal = table.Column<string>(nullable: true),
                    Flight_number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.id);
                    table.ForeignKey(
                        name: "FK_Flights_Flights_header_Flight_number",
                        column: x => x.Flight_number,
                        principalTable: "Flights_header",
                        principalColumn: "Flightno",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_Flight_number",
                table: "Flights",
                column: "Flight_number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Flights_header");
        }
    }
}
