using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoClub.Migrations
{
    public partial class CreateAboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 40, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 800, nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsChoseUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsChoseUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsMoreInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Block1Title = table.Column<string>(maxLength: 30, nullable: false),
                    Block1Inside = table.Column<string>(maxLength: 400, nullable: false),
                    Block2Title = table.Column<string>(maxLength: 30, nullable: false),
                    Block2Inside = table.Column<string>(maxLength: 400, nullable: false),
                    Block3Title = table.Column<string>(maxLength: 30, nullable: false),
                    Block3Inside = table.Column<string>(maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsMoreInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 255, nullable: true),
                    OffersTitle = table.Column<string>(maxLength: 55, nullable: false),
                    OffersDescription = table.Column<string>(maxLength: 255, nullable: false),
                    OffersSection = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsOffers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "AboutUsChoseUs");

            migrationBuilder.DropTable(
                name: "AboutUsMoreInfo");

            migrationBuilder.DropTable(
                name: "AboutUsOffers");
        }
    }
}
