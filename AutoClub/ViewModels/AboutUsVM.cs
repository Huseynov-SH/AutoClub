using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.Models;

namespace AutoClub.ViewModels
{
    public class AboutUsVM
    {
        public AboutUs AboutUs { get; set; }
        public AboutUsMoreInfo AboutUsMoreInfo { get; set; }
        public IEnumerable<AboutUsOffers> AboutUsOffers { get; set; }
        public IEnumerable<AboutUsChoseUs> AboutUsChoseUs { get; set; }

        public IEnumerable<AppUser> Members { get; set; }
    }
}
