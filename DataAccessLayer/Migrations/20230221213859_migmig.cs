using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Projects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_StudentID",
                table: "Projects",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Students_StudentID",
                table: "Projects",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Students_StudentID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_StudentID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Projects");
        }
    }
}
