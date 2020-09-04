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

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "pf_Topic",
                nullable: false,
                defaultValue: 0
                );

            migrationBuilder.AlterColumn<int>(
                name: "AnswerPostID",
                table: "pf_Topic",
                nullable: false,
                defaultValue: 0
                );

            migrationBuilder.AlterColumn<int>(
                name: "Image",
                table: "pf_Topic",
                nullable: true,
                defaultValue: ""
                );

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "pf_Topic",
                nullable: true,
                defaultValue: ""
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
