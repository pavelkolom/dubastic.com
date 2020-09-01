using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class MakeChangesv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "pf_Topic",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "pf_Topic");

            migrationBuilder.UpdateData(
                table: "pf_PopForumsUser",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2020, 8, 26, 18, 43, 31, 584, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "pf_SecurityLog",
                keyColumn: "SecurityLogID",
                keyValue: 1,
                column: "ActivityDate",
                value: new DateTime(2020, 8, 26, 18, 43, 31, 626, DateTimeKind.Local).AddTicks(9167));
        }
    }
}
