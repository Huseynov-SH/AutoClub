using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class ShopProduct
    {
        public int Id { get; set; }
        public int ShopSubCategoryId { get; set; }
        [Required, StringLength(45)]
        public string Title { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public bool Blocked { get; set; }
        public DateTime CreateDate { get; set; }

        public string AppUserId { get; set; }

        public ShopCategory ShopCategory { get; set; }
        public ShopSubCategory ShopSubCategory { get; set; }

        public virtual IEnumerable<ShopProductImage> ShopProductImages { get; set; }

        [NotMapped]
        public List<IFormFile> Photos { get; set; }
    }
}
