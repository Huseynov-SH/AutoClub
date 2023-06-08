using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.Models;

namespace AutoClub.ViewModels
{
    public class BasketVM
    {
        public ShopProduct ShopProduct { get; set; }
        public int Quantity { get; set; }
    }
}
