using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Records",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Black Sabbath" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Name", "SerialNumber" },
                values: new object[] { 1, 1, "Heaven and Hell", "9102 752" });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Condition", "RecordId" },
                values: new object[,]
                {
                    { 1, 110, 1 },
                    { 2, 101, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "RecordId", "TrackNo" },
                values: new object[,]
                {
                    { 1, "Neon Knights", 1, 1 },
                    { 2, "Children of the Sea", 1, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Records",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);
        }
    }
}
