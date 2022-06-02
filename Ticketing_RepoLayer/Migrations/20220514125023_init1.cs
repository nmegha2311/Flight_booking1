using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticketing_RepoLayer.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Header",
                columns: table => new
                {
                    Emailid = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Nos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Header", x => x.Emailid);
                });

            migrationBuilder.CreateTable(
                name: "customer_Details",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RName = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    meal = table.Column<string>(nullable: true),
                    SeatNumbers = table.Column<string>(nullable: true),
                    Emailid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customer_Details_Customer_Header_Emailid",
                        column: x => x.Emailid,
                        principalTable: "Customer_Header",
                        principalColumn: "Emailid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_Details_Emailid",
                table: "customer_Details",
                column: "Emailid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer_Details");

            migrationBuilder.DropTable(
                name: "Customer_Header");
        }
    }
}
