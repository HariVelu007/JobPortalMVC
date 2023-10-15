using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoratlServices.Migrations
{
    public partial class usertableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "JobSeekers");

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "JobSeekers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Employers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AK_Users_EMail", x => x.EMail);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_EMail",
                table: "JobSeekers",
                column: "EMail",
                unique: true,
                filter: "[EMail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_EMail",
                table: "Employers",
                column: "EMail",
                unique: true,
                filter: "[EMail] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_Users_EMail",
                table: "Employers",
                column: "EMail",
                principalTable: "Users",
                principalColumn: "EMail");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_Users_EMail",
                table: "JobSeekers",
                column: "EMail",
                principalTable: "Users",
                principalColumn: "EMail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employers_Users_EMail",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_Users_EMail",
                table: "JobSeekers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekers_EMail",
                table: "JobSeekers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_EMail",
                table: "Employers");

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "JobSeekers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EMail",
                table: "Employers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
