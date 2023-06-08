using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class VehicleSearchModel
    {
        public int? Id { get; set; }
        public int? Make { get; set; }
        public int? Model { get; set; }
        public string Status { get; set; }
        public int? MinYear { get; set; }
        public int? MaxYear { get; set; }
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public int? BodyType { get; set; }
    }
}
