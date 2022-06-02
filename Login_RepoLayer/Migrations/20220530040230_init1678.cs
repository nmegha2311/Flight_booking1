using Microsoft.EntityFrameworkCore.Migrations;

namespace Login_RepoLayer.Migrations
{
    public partial class init1678 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Admin",
                table: "Login",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Login");
        }
    }
}
