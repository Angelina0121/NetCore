using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MF.MyAirport.EF.Migrations
{
    public partial class fintp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "Code_Iata",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "Date_Creation",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "VolId",
                table: "Bagages",
                newName: "VolID");

            migrationBuilder.RenameColumn(
                name: "BagageId",
                table: "Bagages",
                newName: "BagageID");

            migrationBuilder.RenameIndex(
                name: "IX_Bagages_VolId",
                table: "Bagages",
                newName: "IX_Bagages_VolID");

            migrationBuilder.AddColumn<string>(
                name: "CodeIata",
                table: "Bagages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "Bagages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "CodeIata",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "VolID",
                table: "Bagages",
                newName: "VolId");

            migrationBuilder.RenameColumn(
                name: "BagageID",
                table: "Bagages",
                newName: "BagageId");

            migrationBuilder.RenameIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages",
                newName: "IX_Bagages_VolId");

            migrationBuilder.AddColumn<string>(
                name: "Code_Iata",
                table: "Bagages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Creation",
                table: "Bagages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
