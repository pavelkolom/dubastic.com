using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class MakeChangesv5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsModerated",
                table: "pf_Topic",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "pf_PopForumsUser",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 8, 31, 18, 44, 50, 326, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "pf_SecurityLog",
                keyColumn: "SecurityLogID",
                keyValue: 1,
                column: "ActivityDate",
                value: new DateTime(2020, 8, 31, 18, 44, 50, 362, DateTimeKind.Local).AddTicks(2183));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsModerated",
                table: "pf_Topic");

            migrationBuilder.UpdateData(
                table: "pf_PopForumsUser",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 8, 26, 19, 7, 21, 569, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "pf_SecurityLog",
                keyColumn: "SecurityLogID",
                keyValue: 1,
                column: "ActivityDate",
                value: new DateTime(2020, 8, 26, 19, 7, 21, 602, DateTimeKind.Local).AddTicks(6115));
        }
    }
}
