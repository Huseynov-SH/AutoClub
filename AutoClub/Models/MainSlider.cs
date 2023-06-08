using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class MainSlider
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [Required, StringLength(30)]
        public string SliderTitle { get; set; }
        [Required, StringLength(30)]
        public string SliderMain { get; set; }
        [StringLength(30)]
        public string SliderSubTitle { get; set; }

        [NotMapped, Display(Name = "Select new image")]
        public IFormFile Photo { get; set; }
    }
}
