using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class AboutUsChoseUs
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Description { get; set; }
    }
}
