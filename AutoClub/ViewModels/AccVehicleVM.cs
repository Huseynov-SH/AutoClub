using AutoClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewModels
{
    public class AccVehicleVM
    {
        public IEnumerable<Vehicle> Vehicles { get; set; }
        public IEnumerable<Make> Makes { get; set; }
        public IEnumerable<VehicleModel> VehicleModels { get; set; }
        public IEnumerable<VehicleImage> VehicleImages { get; set; }
        public IEnumerable<FavoriteVehicle> FavoriteVehicles { get; set; }
        public AppUser AppUser { get; set; }
    }
}
