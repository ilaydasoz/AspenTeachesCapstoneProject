using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_son : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentStudent_Assignments_AssignmentId",
                table: "AssignmentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentStudent_Students_StudentId",
                table: "AssignmentStudent");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "AssignmentStudent",
                newName: "StudentsStudentID");

            migrationBuilder.RenameColumn(
                name: "AssignmentId",
                table: "AssignmentStudent",
                newName: "AssignmentsAssignmentID");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentStudent_StudentId",
                table: "AssignmentStudent",
                newName: "IX_AssignmentStudent_StudentsStudentID");

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
                name: "FK_AssignmentStudent_Assignments_AssignmentsAssignmentID",
                table: "AssignmentStudent",
                column: "AssignmentsAssignmentID",
                principalTable: "Assignments",
                principalColumn: "AssignmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentStudent_Students_StudentsStudentID",
                table: "AssignmentStudent",
                column: "StudentsStudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_AssignmentStudent_Assignments_AssignmentsAssignmentID",
                table: "AssignmentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentStudent_Students_StudentsStudentID",
                table: "AssignmentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Students_StudentID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_StudentID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "StudentsStudentID",
                table: "AssignmentStudent",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "AssignmentsAssignmentID",
                table: "AssignmentStudent",
                newName: "AssignmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentStudent_StudentsStudentID",
                table: "AssignmentStudent",
                newName: "IX_AssignmentStudent_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentStudent_Assignments_AssignmentId",
                table: "AssignmentStudent",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentStudent_Students_StudentId",
                table: "AssignmentStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
