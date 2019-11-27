using Microsoft.EntityFrameworkCore.Migrations;

namespace tangendataportalversion2.Migrations
{
    public partial class datetimename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "downloadDateTime",
                table: "RunTable",
                newName: "dateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "RunTable",
                newName: "downloadDateTime");
        }
    }
}
