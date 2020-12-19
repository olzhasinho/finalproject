using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShop3.Migrations
{
    public partial class fixbug5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "/images/44.png");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "/images/66.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "/images/88.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "/images/des1.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "/images/des2.png");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "/images/3d1.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "/images/3d2.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "/images/4.png");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "/images/6.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "/images/8.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "/images/naruto2.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "/images/naruto4.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "/images/kill2.jpg");

            migrationBuilder.UpdateData(
                table: "Arts",
                keyColumn: "ArtId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "/images/kill4.jpg");
        }
    }
}
