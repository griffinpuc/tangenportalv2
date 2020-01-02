using Microsoft.EntityFrameworkCore.Migrations;

namespace tangenportalv2.Migrations
{
    public partial class feck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultMod_RunTable_RunId",
                table: "ResultMod");

            migrationBuilder.DropForeignKey(
                name: "FK_TargetMod_RunTable_RunId",
                table: "TargetMod");

            migrationBuilder.DropForeignKey(
                name: "FK_WellMod_RunTable_RunId",
                table: "WellMod");

            migrationBuilder.RenameColumn(
                name: "RunId",
                table: "WellMod",
                newName: "RunModId");

            migrationBuilder.RenameIndex(
                name: "IX_WellMod_RunId",
                table: "WellMod",
                newName: "IX_WellMod_RunModId");

            migrationBuilder.RenameColumn(
                name: "RunId",
                table: "TargetMod",
                newName: "RunModId");

            migrationBuilder.RenameIndex(
                name: "IX_TargetMod_RunId",
                table: "TargetMod",
                newName: "IX_TargetMod_RunModId");

            migrationBuilder.RenameColumn(
                name: "RunId",
                table: "ResultMod",
                newName: "RunModId");

            migrationBuilder.RenameIndex(
                name: "IX_ResultMod_RunId",
                table: "ResultMod",
                newName: "IX_ResultMod_RunModId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultMod_RunTable_RunModId",
                table: "ResultMod",
                column: "RunModId",
                principalTable: "RunTable",
                principalColumn: "RunId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TargetMod_RunTable_RunModId",
                table: "TargetMod",
                column: "RunModId",
                principalTable: "RunTable",
                principalColumn: "RunId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WellMod_RunTable_RunModId",
                table: "WellMod",
                column: "RunModId",
                principalTable: "RunTable",
                principalColumn: "RunId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultMod_RunTable_RunModId",
                table: "ResultMod");

            migrationBuilder.DropForeignKey(
                name: "FK_TargetMod_RunTable_RunModId",
                table: "TargetMod");

            migrationBuilder.DropForeignKey(
                name: "FK_WellMod_RunTable_RunModId",
                table: "WellMod");

            migrationBuilder.RenameColumn(
                name: "RunModId",
                table: "WellMod",
                newName: "RunId");

            migrationBuilder.RenameIndex(
                name: "IX_WellMod_RunModId",
                table: "WellMod",
                newName: "IX_WellMod_RunId");

            migrationBuilder.RenameColumn(
                name: "RunModId",
                table: "TargetMod",
                newName: "RunId");

            migrationBuilder.RenameIndex(
                name: "IX_TargetMod_RunModId",
                table: "TargetMod",
                newName: "IX_TargetMod_RunId");

            migrationBuilder.RenameColumn(
                name: "RunModId",
                table: "ResultMod",
                newName: "RunId");

            migrationBuilder.RenameIndex(
                name: "IX_ResultMod_RunModId",
                table: "ResultMod",
                newName: "IX_ResultMod_RunId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultMod_RunTable_RunId",
                table: "ResultMod",
                column: "RunId",
                principalTable: "RunTable",
                principalColumn: "RunId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TargetMod_RunTable_RunId",
                table: "TargetMod",
                column: "RunId",
                principalTable: "RunTable",
                principalColumn: "RunId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WellMod_RunTable_RunId",
                table: "WellMod",
                column: "RunId",
                principalTable: "RunTable",
                principalColumn: "RunId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
