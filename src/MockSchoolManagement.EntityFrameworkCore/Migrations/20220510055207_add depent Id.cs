using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MockSchoolManagement.EntityFrameworkCore.Migrations
{
    public partial class adddepentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Person_TeacherID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_TeacherID",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Person",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Departments",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Departments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AdministratorId",
                table: "Departments",
                column: "AdministratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Person_AdministratorId",
                table: "Departments",
                column: "AdministratorId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Person_AdministratorId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_AdministratorId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Departments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Departments",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_TeacherID",
                table: "Departments",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Person_TeacherID",
                table: "Departments",
                column: "TeacherID",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
