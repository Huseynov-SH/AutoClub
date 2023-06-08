using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoClub.Migrations
{
    public partial class UpdateVehicleAndVehicleImageAddAppUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Vehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Vehicles");
        }
    }
}
