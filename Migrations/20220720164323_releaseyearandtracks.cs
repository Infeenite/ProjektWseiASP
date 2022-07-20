using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop.Migrations
{
    public partial class releaseyearandtracks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReleaseYear",
                table: "Records",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Judas Priest" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Iron Maiden" });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseYear",
                value: "1980");

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 2, 3, 0, "Piece of Mind", "1983", "9102 752" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 3, 2, 0, "Defenders of the Faith", "1984", "9102 752" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "RecordId", "TrackNo" },
                values: new object[,]
                {
                    { 3, "The Trooper", 2, 5 },
                    { 4, "Rock Hard Ride Free", 3, 3 },
                    { 5, "Die with your boots on", 2, 4 },
                    { 6, "The Sentinel", 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_RecordId",
                table: "Tracks",
                column: "RecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Records_RecordId",
                table: "Tracks",
                column: "RecordId",
                principalTable: "Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Records_RecordId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_RecordId",
                table: "Tracks");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Records");
        }
    }
}
