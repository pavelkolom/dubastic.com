using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class MakeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Image",
                table: "pf_Forum",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "pf_Forum",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "pf_PopForumsUser",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 8, 23, 0, 4, 53, 622, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "pf_SecurityLog",
                keyColumn: "SecurityLogID",
                keyValue: 1,
                column: "ActivityDate",
                value: new DateTime(2020, 8, 23, 0, 4, 53, 651, DateTimeKind.Local).AddTicks(9752));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "pf_Forum");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "pf_Forum");

            migrationBuilder.UpdateData(
                table: "pf_PopForumsUser",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 7, 11, 17, 2, 34, 164, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "pf_SecurityLog",
                keyColumn: "SecurityLogID",
                keyValue: 1,
                column: "ActivityDate",
                value: new DateTime(2020, 7, 11, 17, 2, 34, 199, DateTimeKind.Local).AddTicks(7803));
        }
    }
}
