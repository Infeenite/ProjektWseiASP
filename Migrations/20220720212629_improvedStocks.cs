using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop.Migrations
{
    public partial class improvedStocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stocks_RecordId",
                table: "Stocks",
                column: "RecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Records_RecordId",
                table: "Stocks",
                column: "RecordId",
                principalTable: "Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Records_RecordId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_RecordId",
                table: "Stocks");
        }
    }
}
