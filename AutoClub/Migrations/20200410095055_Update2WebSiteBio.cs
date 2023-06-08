using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoClub.Migrations
{
    public partial class Update2WebSiteBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutUs",
                table: "WebSiteBios",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Copyright",
                table: "WebSiteBios",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "WebSiteBios",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GooglePlusLink",
                table: "WebSiteBios",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "WebSiteBios",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkypeLink",
                table: "WebSiteBios",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterLink",
                table: "WebSiteBios",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink",
                table: "WebSiteBios",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutUs",
                table: "WebSiteBios");

            migrationBuilder.DropColumn(
                name: "Copyright",
                table: "WebSiteBios");

            migrationBuilder.DropColumn(
                name: "FacebookLink",
                table: "WebSiteBios");

            migrationBuilder.DropColumn(
                name: "GooglePlusLink",
                table: "WebSiteBios");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "WebSiteBios");

            migrationBuilder.DropColumn(
                name: "SkypeLink",
                table: "WebSiteBios");

            migrationBuilder.DropColumn(
                name: "TwitterLink",
                table: "WebSiteBios");

            migrationBuilder.DropColumn(
                name: "YoutubeLink",
                table: "WebSiteBios");
        }
    }
}
