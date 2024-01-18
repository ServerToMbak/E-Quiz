using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SınavProjectTask.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamTime",
                table: "Exams");

            migrationBuilder.AddColumn<Guid>(
                name: "CorrectOptionId",
                table: "Questions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "OptionType",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "IsOptionCorrect",
                table: "Options",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "MaximumTime",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectOptionId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "OptionType",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsOptionCorrect",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "MaximumTime",
                table: "Exams");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "ExamTime",
                table: "Exams",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }
    }
}
