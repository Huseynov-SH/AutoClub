using AutoClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewModels
{
    public class DetailsVM
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<VehicleFeatures> VehicleFeatures { get; set; }
        public IEnumerable<Make> Make { get; set; }
        public IEnumerable<VehicleModel> VehicleModel { get; set; }
        public IEnumerable<VehicleImage> VehicleImages { get; set; }
        public IEnumerable<BodyType> BodyTypes { get; set; }
        public IEnumerable<DriveType> DriveTypes { get; set; }
        public IEnumerable<TransmissionType> TransmissionTypes { get; set; }
        public IEnumerable<FuelType> FuelTypes { get; set; }
        public IEnumerable<Vehicle> RelatedVehicles  { get; set; }
        public OfferPriceMessage OfferPriceMessage { get; set; }
        public ContactMessage ContactMessage { get; set; }
    }
}
