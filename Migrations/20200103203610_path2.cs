using Microsoft.EntityFrameworkCore.Migrations;

namespace tangenportalv2.Migrations
{
    public partial class path2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "storagepath",
                table: "InstrumentTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "storagepath",
                table: "InstrumentTable");
        }
    }
}
