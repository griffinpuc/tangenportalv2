using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tangendataportalversion2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BatchTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    batchName = table.Column<string>(nullable: true),
                    batchURL = table.Column<string>(nullable: true),
                    batchSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    localAddress = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    lastPing = table.Column<string>(nullable: true),
                    dateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RunTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sampleId = table.Column<string>(nullable: true),
                    uniqueId = table.Column<string>(nullable: true),
                    dateTime = table.Column<string>(nullable: true),
                    assayId = table.Column<string>(nullable: true),
                    assayName = table.Column<string>(nullable: true),
                    kitLotId = table.Column<string>(nullable: true),
                    instrumentUuid = table.Column<string>(nullable: true),
                    instrumentName = table.Column<string>(nullable: true),
                    DirPointer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunTable", x => x.Id);
                });

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
                name: "BatchTable");

            migrationBuilder.DropTable(
                name: "InstrumentTable");

            migrationBuilder.DropTable(
                name: "ResultMod");

            migrationBuilder.DropTable(
                name: "TargetMod");

            migrationBuilder.DropTable(
                name: "WellMod");

            migrationBuilder.DropTable(
                name: "RunTable");
        }
    }
}
