using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewModels
{
    public class UpdateMyProduct
    {
        [Required, StringLength(45)]
        public string Title { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
