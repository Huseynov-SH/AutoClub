using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoClub.Migrations
{
    public partial class CreateShopProductAndShopProductİmage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShopSubCategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 45, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Blocked = table.Column<bool>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    ShopCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProducts_ShopCategories_ShopCategoryId",
                        column: x => x.ShopCategoryId,
                        principalTable: "ShopCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopProducts_ShopSubCategories_ShopSubCategoryId",
                        column: x => x.ShopSubCategoryId,
                        principalTable: "ShopSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    ShopProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopProductImages_ShopProducts_ShopProductId",
                        column: x => x.ShopProductId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductImages_ShopProductId",
                table: "ShopProductImages",
                column: "ShopProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_ShopCategoryId",
                table: "ShopProducts",
                column: "ShopCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_ShopSubCategoryId",
                table: "ShopProducts",
                column: "ShopSubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopProductImages");

            migrationBuilder.DropTable(
                name: "ShopProducts");
        }
    }
}
