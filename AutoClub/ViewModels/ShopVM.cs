using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.Models;

namespace AutoClub.ViewModels
{
    public class ShopVM
    {
        public ShopCategory ShopCategory { get; set; }
        public IEnumerable<ShopCategory> ShopCategories { get; set; }
        public ShopSubCategory ShopSubCategory { get; set; }
        public IEnumerable<ShopSubCategory> ShopSubCategories { get; set; }
        public ShopProduct ShopProduct { get; set; }
        public IEnumerable<ShopProduct> ShopProducts { get; set; }
        public IEnumerable<ShopProductImage> ShopProductImages { get; set; }
        public IEnumerable<ShopProductImage> ShopProductAllImages { get; set; }
        public IEnumerable<ShopProduct> RelatedProducts { get; set; }

        public AppUser AppUser { get; set; }
    }
}
