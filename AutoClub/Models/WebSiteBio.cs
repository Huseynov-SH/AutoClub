using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class WebSiteBio
    {
        public int Id { get; set; }

        [Required, StringLength(50), MinLength(3, ErrorMessage = "You must enter at least 3 characters")]
        public string Address { get; set; }

        [Required, StringLength(20), MinLength(5, ErrorMessage = "You must enter at least 5 characters")]
        public string Phone { get; set; }

        [StringLength(20), MinLength(5, ErrorMessage = "You must enter at least 5 characters")]
        public string Fax { get; set; }

        [Required, StringLength(30), MinLength(5, ErrorMessage = "You must enter at least 5 characters")]
        public string Email { get; set; }

        [Required, StringLength(60), MinLength(5, ErrorMessage = "You must enter at least 5 characters")]
        public string OpeningHoursSales { get; set; }

        [StringLength(800)]
        public string LocationMap { get; set; }

        [StringLength(255)]
        public string AboutUs { get; set; }

        [StringLength(80)]
        public string Copyright { get; set; }

        [StringLength(255)]
        public string FacebookLink { get; set; }

        [StringLength(255)]
        public string TwitterLink { get; set; }

        [StringLength(255)]
        public string GooglePlusLink { get; set; }

        [StringLength(255)]
        public string InstagramLink { get; set; }

        [StringLength(255)]
        public string YoutubeLink { get; set; }

        [StringLength(255)]
        public string SkypeLink { get; set; }
    }
}
