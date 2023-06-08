using AutoClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewModels
{
    public class CompareVM
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Make> Makes { get; set; }
        public IEnumerable<VehicleModel> VehicleModels { get; set; }
    }
}
