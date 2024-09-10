using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeMVC.Migrations
{
    /// <inheritdoc />
    public partial class dabaseChangesAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Employee Name:",
                value: "Prajwol Basnet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Employee Name:",
                value: "Prjawol Basnet");
        }
    }
}
