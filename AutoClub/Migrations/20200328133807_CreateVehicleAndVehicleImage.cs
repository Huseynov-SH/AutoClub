using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoClub.Migrations
{
    public partial class CreateVehicleAndVehicleImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleModelId = table.Column<int>(nullable: false),
                    ManufacturerYear = table.Column<DateTime>(nullable: false),
                    BodyTypeId = table.Column<int>(nullable: false),
                    NoOfSeats = table.Column<int>(nullable: false),
                    NoOfDoors = table.Column<int>(nullable: false),
                    TransmissionTypeId = table.Column<int>(nullable: false),
                    DriveTypeId = table.Column<int>(nullable: false),
                    NoOfCylinders = table.Column<int>(nullable: false),
                    EngineCapacity = table.Column<int>(nullable: false),
                    FuelTypeId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 20, nullable: false),
                    CityFuelEconomy = table.Column<int>(nullable: false),
                    HwyFuelEconomy = table.Column<int>(nullable: false),
                    VehicleFeaturesId = table.Column<int>(nullable: false),
                    VideoLink = table.Column<string>(maxLength: 300, nullable: true),
                    Description = table.Column<string>(maxLength: 1500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal", nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    ExteriorColor = table.Column<string>(maxLength: 20, nullable: false),
                    InteriorColor = table.Column<string>(maxLength: 20, nullable: false),
                    Registration = table.Column<bool>(nullable: false),
                    RegistrationPlateNumber = table.Column<string>(maxLength: 10, nullable: true),
                    RegistrationNumber = table.Column<string>(maxLength: 20, nullable: true),
                    RegistrationExpiryMonth = table.Column<string>(maxLength: 20, nullable: true),
                    RegistrationExpiryYear = table.Column<int>(nullable: false),
                    CurrentAddress = table.Column<string>(maxLength: 255, nullable: false),
                    City = table.Column<string>(maxLength: 80, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PlanType = table.Column<bool>(nullable: false),
                    CupunCode = table.Column<string>(maxLength: 10, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Blocked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_BodyTypes_BodyTypeId",
                        column: x => x.BodyTypeId,
                        principalTable: "BodyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_DriveTypes_DriveTypeId",
                        column: x => x.DriveTypeId,
                        principalTable: "DriveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_TransmissionTypes_TransmissionTypeId",
                        column: x => x.TransmissionTypeId,
                        principalTable: "TransmissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleFeatures_VehicleFeaturesId",
                        column: x => x.VehicleFeaturesId,
                        principalTable: "VehicleFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleImages_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_VehicleId",
                table: "VehicleImages",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BodyTypeId",
                table: "Vehicles",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriveTypeId",
                table: "Vehicles",
                column: "DriveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelTypeId",
                table: "Vehicles",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_TransmissionTypeId",
                table: "Vehicles",
                column: "TransmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleFeaturesId",
                table: "Vehicles",
                column: "VehicleFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleModelId",
                table: "Vehicles",
                column: "VehicleModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleImages");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
