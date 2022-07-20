using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop.Migrations
{
    public partial class imageurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://i.discogs.com/VXXKjs87ESPmntp4jgYGQv-Q16EKJQnBGdX0NF-1vys/rs:fit/g:sm/q:90/h:594/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTY3NzMz/Ny0xMzMyNzQ4NTk1/LmpwZWc.jpeg");

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://i.discogs.com/VyqY8388sgwjGVc25Z6FQbLLgXlmPgyGL7AkYrfgidA/rs:fit/g:sm/q:90/h:600/w:598/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTE4Mzk4/NDItMTU5MDE1MzU5/My02MTc3LmpwZWc.jpeg");

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://i.discogs.com/bxSIVqkuJrEplrBi4gkZNJA5hEllnwN-q_r7PYS5T8o/rs:fit/g:sm/q:90/h:599/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM3MjMx/Mi0xNTkwMzE5NjY4/LTU2NDkuanBlZw.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Records");
        }
    }
}
