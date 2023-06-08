using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        [Required, StringLength(40)]
        public string Title { get; set; }
        [Required, StringLength(200)]
        public string SubTitle { get; set; }
        [Required, StringLength(800)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [NotMapped, Display(Name = "Select new image")]
        public IFormFile Photo { get; set; }
    }
}
