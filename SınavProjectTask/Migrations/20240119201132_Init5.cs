using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SınavProjectTask.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuccessPoing",
                table: "Exams",
                newName: "SuccessPoint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuccessPoint",
                table: "Exams",
                newName: "SuccessPoing");
        }
    }
}
