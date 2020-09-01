using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class MakeChangesv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "pf_Forum",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "pf_PopForumsUser",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 8, 23, 0, 24, 47, 798, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "pf_SecurityLog",
                keyColumn: "SecurityLogID",
                keyValue: 1,
                column: "ActivityDate",
                value: new DateTime(2020, 8, 23, 0, 24, 47, 828, DateTimeKind.Local).AddTicks(1717));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Image",
                table: "pf_Forum",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
