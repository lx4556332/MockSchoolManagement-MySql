using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MockSchoolManagement.EntityFrameworkCore.Migrations
{
    public partial class updatestudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ChineseScore",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "EnglishScore",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MathScore",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentName",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentPhoneNo",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCode",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserSex",
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
                name: "Age",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ChineseScore",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EnglishScore",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "MathScore",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ParentName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ParentPhoneNo",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "UserCode",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "UserSex",
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
