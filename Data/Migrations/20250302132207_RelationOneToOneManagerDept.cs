using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Session_Three_Relation.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelationOneToOneManagerDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "managerId",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_departments_managerId",
                table: "departments",
                column: "managerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_instructors_managerId",
                table: "departments",
                column: "managerId",
                principalTable: "instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_instructors_managerId",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_managerId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "managerId",
                table: "departments");
        }
    }
}
