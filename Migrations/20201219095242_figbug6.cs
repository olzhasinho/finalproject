using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShop3.Migrations
{
    public partial class figbug6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 1,
                column: "Name",
                value: "c++");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "Name" },
                values: new object[] { "/images/44.jpeg", "c#" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 3,
                column: "Name",
                value: "java");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 4,
                column: "Name",
                value: "asp.net");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 5,
                column: "Name",
                value: "videosmile");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 6,
                column: "Name",
                value: "Super Photoshop");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 7,
                column: "Name",
                value: "Plane modeling form 0");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 8,
                column: "Name",
                value: "Merz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 1,
                column: "Name",
                value: "Kaneki Ken");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "Name" },
                values: new object[] { "/images/44.png", "Kaneki Ken2" });

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 3,
                column: "Name",
                value: "Kaneki Ken3");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 4,
                column: "Name",
                value: "Kaneki Ken4");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 5,
                column: "Name",
                value: "Naruto");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 6,
                column: "Name",
                value: "Naruto2");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 7,
                column: "Name",
                value: "Killing Stalking");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 8,
                column: "Name",
                value: "Killing Stalking2");
        }
    }
}
