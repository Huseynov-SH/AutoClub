using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [StringLength(50), MinLength(3, ErrorMessage = "You must enter at least 3 characters"), Display(Name = "Name")]
        public string FirstName { get; set; }

        [StringLength(50), Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required, StringLength(30)]
        public string Username { get; set; }

        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare(nameof(Password)), Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
