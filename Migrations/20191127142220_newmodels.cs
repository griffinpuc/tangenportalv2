using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tangendataportalversion2.Migrations
{
    public partial class newmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UniqueId",
                table: "RunTable",
                newName: "uniqueId");

            migrationBuilder.RenameColumn(
                name: "SampleId",
                table: "RunTable",
                newName: "sampleId");

            migrationBuilder.RenameColumn(
                name: "KitLotId",
                table: "RunTable",
                newName: "kitLotId");

            migrationBuilder.RenameColumn(
                name: "InstrumentUuid",
                table: "RunTable",
                newName: "instrumentUuid");

            migrationBuilder.RenameColumn(
                name: "InstrumentName",
                table: "RunTable",
                newName: "instrumentName");

            migrationBuilder.RenameColumn(
                name: "DownloadDateTime",
                table: "RunTable",
                newName: "downloadDateTime");

            migrationBuilder.RenameColumn(
                name: "AssayId",
                table: "RunTable",
                newName: "assayId");

            migrationBuilder.AddColumn<string>(
                name: "assayName",
                table: "RunTable",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ResultMod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    outcomeCode = table.Column<string>(nullable: true),
                    outcomeString = table.Column<string>(nullable: true),
                    RunModId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultMod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultMod_RunTable_RunModId",
                        column: x => x.RunModId,
                        principalTable: "RunTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TargetMod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    targetId = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    outcomeCode = table.Column<string>(nullable: true),
                    outcomeString = table.Column<string>(nullable: true),
                    RunModId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetMod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetMod_RunTable_RunModId",
                        column: x => x.RunModId,
                        principalTable: "RunTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WellMod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    wellId = table.Column<string>(nullable: true),
                    species = table.Column<string>(nullable: true),
                    cq = table.Column<string>(nullable: true),
                    RunModId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellMod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WellMod_RunTable_RunModId",
                        column: x => x.RunModId,
                        principalTable: "RunTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResultMod_RunModId",
                table: "ResultMod",
                column: "RunModId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetMod_RunModId",
                table: "TargetMod",
                column: "RunModId");

            migrationBuilder.CreateIndex(
                name: "IX_WellMod_RunModId",
                table: "WellMod",
                column: "RunModId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultMod");

            migrationBuilder.DropTable(
                name: "TargetMod");

            migrationBuilder.DropTable(
                name: "WellMod");

            migrationBuilder.DropColumn(
                name: "assayName",
                table: "RunTable");

            migrationBuilder.RenameColumn(
                name: "uniqueId",
                table: "RunTable",
                newName: "UniqueId");

            migrationBuilder.RenameColumn(
                name: "sampleId",
                table: "RunTable",
                newName: "SampleId");

            migrationBuilder.RenameColumn(
                name: "kitLotId",
                table: "RunTable",
                newName: "KitLotId");

            migrationBuilder.RenameColumn(
                name: "instrumentUuid",
                table: "RunTable",
                newName: "InstrumentUuid");

            migrationBuilder.RenameColumn(
                name: "instrumentName",
                table: "RunTable",
                newName: "InstrumentName");

            migrationBuilder.RenameColumn(
                name: "downloadDateTime",
                table: "RunTable",
                newName: "DownloadDateTime");

            migrationBuilder.RenameColumn(
                name: "assayId",
                table: "RunTable",
                newName: "AssayId");
        }
    }
}
