using Microsoft.EntityFrameworkCore.Migrations;

namespace AdsMaster.DB.Migrations
{
    public partial class MakeChangesv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "am_ContactMessage",
                columns: table => new
                {
                    ContactMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Message = table.Column<string>(type: "NVARCHAR(4000)", nullable: false),
                    IsViewed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_am_ContactMessage", x => x.ContactMessageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "am_ContactMessage");
        }
    }
}
