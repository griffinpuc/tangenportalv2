using Microsoft.EntityFrameworkCore.Migrations;

namespace tangendataportalversion2.Migrations
{
    public partial class device : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "InstrumentTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "InstrumentTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "InstrumentTable");

            migrationBuilder.DropColumn(
                name: "username",
                table: "InstrumentTable");
        }
    }
}
