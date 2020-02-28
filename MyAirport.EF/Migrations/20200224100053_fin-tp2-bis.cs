using Microsoft.EntityFrameworkCore.Migrations;

namespace MF.MyAirport.EF.Migrations
{
    public partial class fintp2bis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
