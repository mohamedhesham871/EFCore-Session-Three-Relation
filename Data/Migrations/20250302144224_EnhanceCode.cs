using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Session_Three_Relation.Data.Migrations
{
    /// <inheritdoc />
    public partial class EnhanceCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_student_Courses_CourseId",
                table: "student_Courses");

            migrationBuilder.DropIndex(
                name: "IX_student_Courses_StudentId",
                table: "student_Courses");

            migrationBuilder.CreateIndex(
                name: "IX_student_Courses_CourseId",
                table: "student_Courses",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_student_Courses_CourseId",
                table: "student_Courses");

            migrationBuilder.CreateIndex(
                name: "IX_student_Courses_CourseId",
                table: "student_Courses",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_student_Courses_StudentId",
                table: "student_Courses",
                column: "StudentId",
                unique: true);
        }
    }
}
