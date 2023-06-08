using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class FavoriteVehicle
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int VehicleId { get; set; }
    }
}
