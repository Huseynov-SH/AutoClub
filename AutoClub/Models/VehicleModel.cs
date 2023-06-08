using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        [Required,StringLength(30)]
        public string Name { get; set; }

        public int MakeId { get; set; }

        public virtual Make Make { get; set; }

    }
}
