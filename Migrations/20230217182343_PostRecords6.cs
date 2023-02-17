using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop.Migrations
{
    public partial class PostRecords6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "GenreId", "ImageUrl", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 112, 5, 1, 0, "https://i.discogs.com/9TFRqx1yW7EkC71l42QR2UEjnSWzcXT5TGDsfWxT4xE/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTY2NzIwODk0/MC01NTc3LmpwZWc.jpeg", "Dark Side of the Moon", "1973", "91 7" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "GenreId", "ImageUrl", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 113, 10, 1, 0, "https://i.discogs.com/rNwD19S4NSiDrD6lTyzZYatIQ-YJ9hy0m4MGqqqtD94/rs:fit/g:sm/q:90/h:498/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ0ODM3/NDktMTM2NjE4Mjg4/NS0xMjA2LmpwZWc.jpeg", "Rising", "1976", "9111 7" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "GenreId", "ImageUrl", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 115, 7, 2, 0, "https://i.discogs.com/dWe2AyguSxJpaaEWbK_mVLL3zs2ejuta0sJCx5BvS8o/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI5MTEy/OTMtMTU5NDI0NTgx/Mi03OTMxLmpwZWc.jpeg", "Thriller", "1982", "92111 7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "GenreId", "ImageUrl", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 4, 5, 1, 0, "https://i.discogs.com/9TFRqx1yW7EkC71l42QR2UEjnSWzcXT5TGDsfWxT4xE/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4NzMw/MTMtMTY2NzIwODk0/MC01NTc3LmpwZWc.jpeg", "Dark Side of the Moon", "1973", "91 7" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "GenreId", "ImageUrl", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 5, 10, 1, 0, "https://i.discogs.com/rNwD19S4NSiDrD6lTyzZYatIQ-YJ9hy0m4MGqqqtD94/rs:fit/g:sm/q:90/h:498/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ0ODM3/NDktMTM2NjE4Mjg4/NS0xMjA2LmpwZWc.jpeg", "Rising", "1976", "9111 7" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ArtistId", "Genre", "GenreId", "ImageUrl", "Name", "ReleaseYear", "SerialNumber" },
                values: new object[] { 6, 7, 2, 0, "https://i.discogs.com/dWe2AyguSxJpaaEWbK_mVLL3zs2ejuta0sJCx5BvS8o/rs:fit/g:sm/q:90/h:600/w:597/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTI5MTEy/OTMtMTU5NDI0NTgx/Mi03OTMxLmpwZWc.jpeg", "Thriller", "1982", "92111 7" });
        }
    }
}
