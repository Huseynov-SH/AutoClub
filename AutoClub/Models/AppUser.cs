using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(50), MinLength(3, ErrorMessage = "You must enter at least 3 characters")]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(50)]
        public string Section { get; set; }
        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        [StringLength(255)]
        public string FacebookLink { get; set; }
        [StringLength(255)]
        public string InstagramLink { get; set; }
        [StringLength(255)]
        public string TwitterLink { get; set; }
        [StringLength(255)]
        public string LinkedinLink { get; set; }

        [StringLength(255)]
        public string EmailPassord { get; set; }


        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
