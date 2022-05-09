using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MockSchoolManagement.EntityFrameworkCore.Migrations
{
    public partial class updatedepart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RowVersion",
                table: "Departments",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp(6)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<string>(
                name: "ClassCode",
                table: "Departments",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ClassScore",
                table: "Departments",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "HeadTeacherName",
                table: "Departments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadTeacherPhone",
                table: "Departments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassCode",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ClassScore",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "HeadTeacherName",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "HeadTeacherPhone",
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
        }
    }
}
