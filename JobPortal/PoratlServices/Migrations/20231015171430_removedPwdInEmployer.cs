using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoratlServices.Migrations
{
    public partial class removedPwdInEmployer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
