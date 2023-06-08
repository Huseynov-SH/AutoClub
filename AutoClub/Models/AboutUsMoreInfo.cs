using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class AboutUsMoreInfo
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Block1Title { get; set; }
        [Required, StringLength(400)]
        public string Block1Inside { get; set; }
        [Required, StringLength(30)]
        public string Block2Title { get; set; }
        [Required, StringLength(400)]
        public string Block2Inside { get; set; }
        [Required, StringLength(30)]
        public string Block3Title { get; set; }
        [Required, StringLength(400)]
        public string Block3Inside { get; set; }
    }
}
