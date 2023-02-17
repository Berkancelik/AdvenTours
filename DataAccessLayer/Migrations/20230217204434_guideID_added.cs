using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class guideID_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides_GuideID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "GuidId",
                table: "Destinations");

            migrationBuilder.RenameColumn(
                name: "GuideID",
                table: "Destinations",
                newName: "GuideId");

            migrationBuilder.RenameIndex(
                name: "IX_Destinations_GuideID",
                table: "Destinations",
                newName: "IX_Destinations_GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides_GuideId",
                table: "Destinations",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides_GuideId",
                table: "Destinations");

            migrationBuilder.RenameColumn(
                name: "GuideId",
                table: "Destinations",
                newName: "GuideID");

            migrationBuilder.RenameIndex(
                name: "IX_Destinations_GuideId",
                table: "Destinations",
                newName: "IX_Destinations_GuideID");

            migrationBuilder.AddColumn<int>(
                name: "GuidId",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides_GuideID",
                table: "Destinations",
                column: "GuideID",
                principalTable: "Guides",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
