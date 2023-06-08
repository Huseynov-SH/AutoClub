using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class ShopCategory
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }

        public virtual ICollection<ShopSubCategory> ShopSubCategories { get; set; }
    }
}
