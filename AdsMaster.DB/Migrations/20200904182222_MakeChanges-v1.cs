using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class MakeChangesv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsModerated",
                table: "pf_Topic",
                nullable: false,
                defaultValue: 0
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
