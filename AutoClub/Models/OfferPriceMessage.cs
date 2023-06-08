using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class OfferPriceMessage
    {
        public int Id { get; set; }
       
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        public int VehicleId { get; set; }
        public int type { get; set; }
    }
}
