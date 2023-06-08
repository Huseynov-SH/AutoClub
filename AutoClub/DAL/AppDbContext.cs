using AutoClub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<WebSiteBio> WebSiteBios { get; set; }

        public DbSet<Make> Makes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<TransmissionType> TransmissionTypes { get; set; }
        public DbSet<DriveType> DriveTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<VehicleFeatures> VehicleFeatures { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleImage> VehicleImages { get; set; }

        public DbSet<FavoriteVehicle> FavoriteVehicles { get; set; }

        public DbSet<MainSlider> MainSliders { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AboutUsOffers> AboutUsOffers { get; set; }
        public DbSet<AboutUsChoseUs> AboutUsChoseUs { get; set; }
        public DbSet<AboutUsMoreInfo> AboutUsMoreInfo { get; set; }

        public DbSet<ShopCategory> ShopCategories { get; set; }
        public DbSet<ShopSubCategory> ShopSubCategories { get; set; }

        public DbSet<ShopProduct> ShopProducts { get; set; }
        public DbSet<ShopProductImage> ShopProductImages { get; set; }

        public DbSet<WebSiteMails> WebSiteMails { get; set; }
    }
}
