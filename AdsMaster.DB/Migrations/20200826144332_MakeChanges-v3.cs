﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class MakeChangesv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "pf_Forum");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "pf_Forum");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "pf_Topic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "pf_Topic",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "pf_Topic");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "pf_Topic");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "pf_Forum",
                type: "nvarchar(max)",
                nullable: true);

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
                value: new DateTime(2020, 8, 23, 0, 24, 47, 798, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "pf_SecurityLog",
                keyColumn: "SecurityLogID",
                keyValue: 1,
                column: "ActivityDate",
                value: new DateTime(2020, 8, 23, 0, 24, 47, 828, DateTimeKind.Local).AddTicks(1717));
        }
    }
}