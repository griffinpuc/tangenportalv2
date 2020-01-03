using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tangenportalv2.Migrations
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
                    dateAdded = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RunTable",
                columns: table => new
                {
                    RunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sampleId = table.Column<string>(nullable: true),
                    uniqueId = table.Column<string>(nullable: true),
                    dateTime = table.Column<string>(nullable: true),
                    assayId = table.Column<string>(nullable: true),
                    assayName = table.Column<string>(nullable: true),
                    kitLotId = table.Column<string>(nullable: true),
                    instrumentUuid = table.Column<string>(nullable: true),
                    instrumentName = table.Column<string>(nullable: true),
                    directoryPath = table.Column<string>(nullable: true),
                    fileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunTable", x => x.RunId);
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
                    RunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultMod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultMod_RunTable_RunId",
                        column: x => x.RunId,
                        principalTable: "RunTable",
                        principalColumn: "RunId",
                        onDelete: ReferentialAction.Cascade);
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
                    RunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetMod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetMod_RunTable_RunId",
                        column: x => x.RunId,
                        principalTable: "RunTable",
                        principalColumn: "RunId",
                        onDelete: ReferentialAction.Cascade);
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
                    RunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WellMod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WellMod_RunTable_RunId",
                        column: x => x.RunId,
                        principalTable: "RunTable",
                        principalColumn: "RunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResultMod_RunId",
                table: "ResultMod",
                column: "RunId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetMod_RunId",
                table: "TargetMod",
                column: "RunId");

            migrationBuilder.CreateIndex(
                name: "IX_WellMod_RunId",
                table: "WellMod",
                column: "RunId");
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
