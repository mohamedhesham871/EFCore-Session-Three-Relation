using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Session_Three_Relation.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableStudnetCourseAndRetations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "student_Courses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_Courses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_student_Courses_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_student_Courses_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "student_Courses");
        }
    }
}
