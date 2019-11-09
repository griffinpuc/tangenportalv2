using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tangendataportalversion2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RunTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SampleId = table.Column<string>(nullable: true),
                    UniqueId = table.Column<string>(nullable: true),
                    DownloadDateTime = table.Column<string>(nullable: true),
                    AssayId = table.Column<string>(nullable: true),
                    KitLotId = table.Column<string>(nullable: true),
                    InstrumentUuid = table.Column<string>(nullable: true),
                    InstrumentName = table.Column<string>(nullable: true),
                    DirPointer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RunTable");
        }
    }
}
