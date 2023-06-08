using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class AboutUsOffers
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [Required, StringLength(55)]
        public string OffersTitle { get; set; }
        [Required, StringLength(255)]
        public string OffersDescription { get; set; }
        [Required, StringLength(20)]
        public string OffersSection { get; set; }

        [NotMapped, Display(Name = "Select new image")]
        public IFormFile Photo { get; set; }
    }
}
