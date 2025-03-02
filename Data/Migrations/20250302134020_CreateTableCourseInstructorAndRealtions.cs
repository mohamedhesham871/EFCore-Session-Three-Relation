using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Session_Three_Relation.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableCourseInstructorAndRealtions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course_Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Instructors", x => new { x.InstructorId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_Course_Instructors_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Instructors_instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Instructors_CourseId",
                table: "Course_Instructors",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Instructors");
        }
    }
}
