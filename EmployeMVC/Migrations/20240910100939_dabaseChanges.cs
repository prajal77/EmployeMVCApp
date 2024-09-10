using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeMVC.Migrations
{
    /// <inheritdoc />
    public partial class dabaseChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Department Name:" },
                values: new object[] { 1, "IT Department" });

            migrationBuilder.InsertData(
                table: "Designation",
                columns: new[] { "Id", "Department Name:" },
                values: new object[] { 1, "Intern" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Employee Address:", "DepartmentId", "DesignationId", "Employee Email:", "Employee Name:", "Employee Phone Number:" },
                values: new object[] { 1, "Bhaktapur", 1, 1, "prajal.basnet0@gmail.com", "Prjawol Basnet", "9861329908" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designation",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
