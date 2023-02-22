using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Instructors_InstructorID",
                table: "Assignments");

            migrationBuilder.DropTable(
                name: "AssignmentStudent");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_InstructorID",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Assignments");

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

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Assignments",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AssignmentStudent",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentStudent", x => new { x.AssignmentId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_AssignmentStudent_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentStudent_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_InstructorID",
                table: "Assignments",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentStudent_StudentId",
                table: "AssignmentStudent",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Instructors_InstructorID",
                table: "Assignments",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "InstructorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
