using AutoClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewModels
{
    public class HomeVM
    {
        public WebSiteBio webSiteBio { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
        public IEnumerable<Vehicle> AllVehicles { get; set; }
        public IEnumerable<Make> Makes { get; set; }
        public IEnumerable<VehicleModel> VehicleModel { get; set; }
        public IEnumerable<VehicleImage> VehicleImages { get; set; }
        public IEnumerable<FuelType> FuelTypes { get; set; }
        public IEnumerable<DriveType> DriveTypes { get; set; }
        public IEnumerable<BodyType> BodyTypes { get; set; }
        public IEnumerable<TransmissionType> TransmissionTypes { get; set; }
        public IEnumerable<MainSlider> MainSliders { get; set; }
        public VehicleSearchModel VehicleSearchModel { get; set; }
    }
}
