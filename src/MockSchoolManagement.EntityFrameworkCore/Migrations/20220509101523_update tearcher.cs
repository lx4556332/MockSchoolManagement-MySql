using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MockSchoolManagement.EntityFrameworkCore.Migrations
{
    public partial class updatetearcher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeachClass",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeachCourseName",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherCode",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherPhone",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Person",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Departments",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TeachClass",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TeachCourseName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TeacherCode",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TeacherPhone",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Person");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Departments",
                type: "timestamp(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldRowVersion: true,
                oldNullable: true)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);
        }
    }
}
