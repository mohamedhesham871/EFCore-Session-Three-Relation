using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Session_Three_Relation.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelationInstructorAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_instructors_departmentId",
                table: "instructors",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_departmentId",
                table: "instructors",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_departmentId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_departmentId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "instructors");
        }
    }
}
