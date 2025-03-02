using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Session_Three_Relation.Data.Migrations
{
    /// <inheritdoc />
    public partial class RealtionStudentAndDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deparmentID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "departmentID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentID",
                table: "students",
                column: "departmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_departmentID",
                table: "students",
                column: "departmentID",
                principalTable: "departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_departmentID",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_departmentID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "deparmentID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "departmentID",
                table: "students");
        }
    }
}
