using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week5_cnnectionWithDB.Migrations
{
    public partial class _0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "EmployeeSalary");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Employees",
                newName: "EmployeeAge");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "floor",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "floor",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "EmployeeSalary",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "EmployeeAge",
                table: "Employees",
                newName: "Age");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Department",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
