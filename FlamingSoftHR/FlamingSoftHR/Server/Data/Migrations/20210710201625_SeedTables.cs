using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlamingSoftHR.Server.Data.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Human Resources" },
                    { 2, "IT" },
                    { 3, "Development" },
                    { 4, "Client Relations" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Permanent employee" },
                    { 2, "Contractor" },
                    { 3, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "LogTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Normal work day " },
                    { 2, "Vacation off day" },
                    { 3, "Sick off day" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "EmployeeType", "FirstName", "LastName", "MiddleName", "UserId" },
                values: new object[,]
                {
                    { 100001, 2, 1, "Gonzalo", "Perez", "Ramiro", "PGoRa_01" },
                    { 100002, 4, 1, "María", "Alvarez", null, "AMa_02" },
                    { 100003, 3, 2, "Ana", "de Jesus", "Sofía", "dJASo_03" },
                    { 100000, 1, 3, "Miguel", "Diaz", null, "DMi_00" }
                });

            migrationBuilder.InsertData(
                table: "LogTimes",
                columns: new[] { "Id", "DateLogged", "Hours", "LogType", "LoggedEmployee" },
                values: new object[] { 2, new DateTime(2020, 1, 3, 8, 30, 0, 0, DateTimeKind.Unspecified), 12.0, 3, 100002 });

            migrationBuilder.InsertData(
                table: "LogTimes",
                columns: new[] { "Id", "DateLogged", "Hours", "LogType", "LoggedEmployee" },
                values: new object[] { 3, new DateTime(2020, 1, 4, 9, 35, 41, 0, DateTimeKind.Unspecified), 5.0, 3, 100003 });

            migrationBuilder.InsertData(
                table: "LogTimes",
                columns: new[] { "Id", "DateLogged", "Hours", "LogType", "LoggedEmployee" },
                values: new object[] { 1, new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 8.5, 1, 100000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100001);

            migrationBuilder.DeleteData(
                table: "LogTimes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LogTimes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LogTimes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LogTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100000);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100002);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100003);

            migrationBuilder.DeleteData(
                table: "LogTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LogTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
