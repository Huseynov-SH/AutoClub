using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoClub.Migrations
{
    public partial class CreateVehicleFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ABS = table.Column<bool>(nullable: false),
                    AlloyWheels = table.Column<bool>(nullable: false),
                    PassengerAirbag = table.Column<bool>(nullable: false),
                    HeatedDoorMirrors = table.Column<bool>(nullable: false),
                    AirConditioning = table.Column<bool>(nullable: false),
                    TripComputer = table.Column<bool>(nullable: false),
                    SideAirbags = table.Column<bool>(nullable: false),
                    AudioRemoteControl = table.Column<bool>(nullable: false),
                    FoldingRearSeats = table.Column<bool>(nullable: false),
                    CentralLockingKeyless = table.Column<bool>(nullable: false),
                    WeatherShields = table.Column<bool>(nullable: false),
                    ElectricFrontSeats = table.Column<bool>(nullable: false),
                    EngineImmobiliser = table.Column<bool>(nullable: false),
                    FogLamps = table.Column<bool>(nullable: false),
                    GPSSatelliteNavigation = table.Column<bool>(nullable: false),
                    HeadlightCovers = table.Column<bool>(nullable: false),
                    LeatherSeats = table.Column<bool>(nullable: false),
                    LeatherTrim = table.Column<bool>(nullable: false),
                    RoofDeflector = table.Column<bool>(nullable: false),
                    RearSpoiler = table.Column<bool>(nullable: false),
                    TintedWindows = table.Column<bool>(nullable: false),
                    TowBar = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFeatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleFeatures");
        }
    }
}
