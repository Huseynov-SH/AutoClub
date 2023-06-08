﻿// <auto-generated />
using System;
using AutoClub.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoClub.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200419231921_CreateWebSiteMails")]
    partial class CreateWebSiteMails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoClub.Models.AboutUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(800);

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("AutoClub.Models.AboutUsChoseUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("AboutUsChoseUs");
                });

            modelBuilder.Entity("AutoClub.Models.AboutUsMoreInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Block1Inside")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Block1Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Block2Inside")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Block2Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Block3Inside")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Block3Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("AboutUsMoreInfo");
                });

            modelBuilder.Entity("AutoClub.Models.AboutUsOffers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<string>("OffersDescription")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("OffersSection")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("OffersTitle")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("AboutUsOffers");
                });

            modelBuilder.Entity("AutoClub.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("EmailPassord")
                        .HasMaxLength(255);

                    b.Property<string>("FacebookLink")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<string>("InstagramLink")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("LinkedinLink")
                        .HasMaxLength(255);

                    b.Property<string>("Location")
                        .HasMaxLength(255);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone")
                        .HasMaxLength(25);

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Section")
                        .HasMaxLength(50);

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("TwitterLink")
                        .HasMaxLength(255);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AutoClub.Models.BodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("BodyTypes");
                });

            modelBuilder.Entity("AutoClub.Models.DriveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("DriveTypes");
                });

            modelBuilder.Entity("AutoClub.Models.FavoriteVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("FavoriteVehicles");
                });

            modelBuilder.Entity("AutoClub.Models.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");
                });

            modelBuilder.Entity("AutoClub.Models.MainSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<string>("SliderMain")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("SliderSubTitle")
                        .HasMaxLength(30);

                    b.Property<string>("SliderTitle")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("MainSliders");
                });

            modelBuilder.Entity("AutoClub.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("AutoClub.Models.ShopCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("ShopCategories");
                });

            modelBuilder.Entity("AutoClub.Models.ShopProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<bool>("Blocked");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("Price");

                    b.Property<int?>("ShopCategoryId");

                    b.Property<int>("ShopSubCategoryId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.HasIndex("ShopCategoryId");

                    b.HasIndex("ShopSubCategoryId");

                    b.ToTable("ShopProducts");
                });

            modelBuilder.Entity("AutoClub.Models.ShopProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ShopProductId");

                    b.HasKey("Id");

                    b.HasIndex("ShopProductId");

                    b.ToTable("ShopProductImages");
                });

            modelBuilder.Entity("AutoClub.Models.ShopSubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("ShopCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ShopCategoryId");

                    b.ToTable("ShopSubCategories");
                });

            modelBuilder.Entity("AutoClub.Models.TransmissionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("TransmissionTypes");
                });

            modelBuilder.Entity("AutoClub.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<bool>("Blocked");

                    b.Property<int>("BodyTypeId");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int>("CityFuelEconomy");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CupunCode")
                        .HasMaxLength(10);

                    b.Property<string>("CurrentAddress")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<int>("DriveTypeId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("EngineCapacity");

                    b.Property<string>("ExteriorColor")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("FuelTypeId");

                    b.Property<int>("HwyFuelEconomy");

                    b.Property<string>("InteriorColor")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("ManufacturerYear");

                    b.Property<int>("Mileage");

                    b.Property<int>("NoOfCylinders");

                    b.Property<int>("NoOfDoors");

                    b.Property<int>("NoOfSeats");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("PlanType");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<bool>("QuotePrice");

                    b.Property<bool>("Registration");

                    b.Property<string>("RegistrationExpiryMonth")
                        .HasMaxLength(20);

                    b.Property<int>("RegistrationExpiryYear");

                    b.Property<string>("RegistrationNumber")
                        .HasMaxLength(20);

                    b.Property<string>("RegistrationPlateNumber")
                        .HasMaxLength(10);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("TransmissionTypeId");

                    b.Property<int>("VehicleFeaturesId");

                    b.Property<int>("VehicleManufacturerYear");

                    b.Property<int>("VehicleModelId");

                    b.Property<string>("VideoLink")
                        .HasMaxLength(300);

                    b.Property<string>("ZipCode")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("DriveTypeId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("TransmissionTypeId");

                    b.HasIndex("VehicleFeaturesId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("AutoClub.Models.VehicleFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ABS");

                    b.Property<bool>("AirConditioning");

                    b.Property<bool>("AlloyWheels");

                    b.Property<bool>("AudioRemoteControl");

                    b.Property<bool>("CentralLockingKeyless");

                    b.Property<bool>("ElectricFrontSeats");

                    b.Property<bool>("EngineImmobiliser");

                    b.Property<bool>("FogLamps");

                    b.Property<bool>("FoldingRearSeats");

                    b.Property<bool>("GPSSatelliteNavigation");

                    b.Property<bool>("HeadlightCovers");

                    b.Property<bool>("HeatedDoorMirrors");

                    b.Property<bool>("LeatherSeats");

                    b.Property<bool>("LeatherTrim");

                    b.Property<bool>("PassengerAirbag");

                    b.Property<bool>("RearSpoiler");

                    b.Property<bool>("RoofDeflector");

                    b.Property<bool>("SideAirbags");

                    b.Property<bool>("TintedWindows");

                    b.Property<bool>("TowBar");

                    b.Property<bool>("TripComputer");

                    b.Property<bool>("WeatherShields");

                    b.HasKey("Id");

                    b.ToTable("VehicleFeatures");
                });

            modelBuilder.Entity("AutoClub.Models.VehicleImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleImages");
                });

            modelBuilder.Entity("AutoClub.Models.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MakeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("AutoClub.Models.WebSiteBio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs")
                        .HasMaxLength(255);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Copyright")
                        .HasMaxLength(80);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FacebookLink")
                        .HasMaxLength(255);

                    b.Property<string>("Fax")
                        .HasMaxLength(20);

                    b.Property<string>("GooglePlusLink")
                        .HasMaxLength(255);

                    b.Property<string>("InstagramLink")
                        .HasMaxLength(255);

                    b.Property<string>("LocationMap")
                        .HasMaxLength(800);

                    b.Property<string>("OpeningHoursSales")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SkypeLink")
                        .HasMaxLength(255);

                    b.Property<string>("TwitterLink")
                        .HasMaxLength(255);

                    b.Property<string>("YoutubeLink")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("WebSiteBios");
                });

            modelBuilder.Entity("AutoClub.Models.WebSiteMails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email1");

                    b.Property<string>("Email1Password");

                    b.Property<string>("Email2");

                    b.Property<string>("Email2Password");

                    b.Property<string>("Email3");

                    b.Property<string>("Email3Password");

                    b.HasKey("Id");

                    b.ToTable("WebSiteMails");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AutoClub.Models.ShopProduct", b =>
                {
                    b.HasOne("AutoClub.Models.ShopCategory", "ShopCategory")
                        .WithMany()
                        .HasForeignKey("ShopCategoryId");

                    b.HasOne("AutoClub.Models.ShopSubCategory", "ShopSubCategory")
                        .WithMany()
                        .HasForeignKey("ShopSubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoClub.Models.ShopProductImage", b =>
                {
                    b.HasOne("AutoClub.Models.ShopProduct", "ShopProduct")
                        .WithMany("ShopProductImages")
                        .HasForeignKey("ShopProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoClub.Models.ShopSubCategory", b =>
                {
                    b.HasOne("AutoClub.Models.ShopCategory", "ShopCategory")
                        .WithMany("ShopSubCategories")
                        .HasForeignKey("ShopCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoClub.Models.Vehicle", b =>
                {
                    b.HasOne("AutoClub.Models.BodyType", "BodyType")
                        .WithMany()
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoClub.Models.DriveType", "DriveType")
                        .WithMany()
                        .HasForeignKey("DriveTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoClub.Models.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoClub.Models.TransmissionType", "TransmissionType")
                        .WithMany()
                        .HasForeignKey("TransmissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoClub.Models.VehicleFeatures", "VehicleFeatures")
                        .WithMany()
                        .HasForeignKey("VehicleFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoClub.Models.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoClub.Models.VehicleImage", b =>
                {
                    b.HasOne("AutoClub.Models.Vehicle", "Vehicle")
                        .WithMany("VehicleImages")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoClub.Models.VehicleModel", b =>
                {
                    b.HasOne("AutoClub.Models.Make", "Make")
                        .WithMany("VehicleModels")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AutoClub.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AutoClub.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoClub.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AutoClub.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
