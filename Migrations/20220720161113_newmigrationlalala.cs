using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop.Migrations
{
    public partial class newmigrationlalala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Records_ArtistId",
                table: "Records",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Artists_ArtistId",
                table: "Records",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Artists_ArtistId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_ArtistId",
                table: "Records");
        }
    }
}
