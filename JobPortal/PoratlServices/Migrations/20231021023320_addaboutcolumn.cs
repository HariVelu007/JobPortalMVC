using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoratlServices.Migrations
{
    public partial class addaboutcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "JobSeekers");
        }
    }
}
