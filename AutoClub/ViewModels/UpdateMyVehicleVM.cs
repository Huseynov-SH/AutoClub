using AutoClub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewModels
{
    public class UpdateMyVehicleVM
    {
        [StringLength(300)]
        public string VideoLink { get; set; }
        [Required, StringLength(1500), MinLength(20, ErrorMessage = "You must enter at least 20 characters")]
        public string Description { get; set; }
        [Required, Column(TypeName = "decimal")]
        public decimal Price { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required, StringLength(255)]
        public string CurrentAddress { get; set; }
        [Required, StringLength(80)]
        public string City { get; set; }
        [StringLength(20)]
        public string ZipCode { get; set; }
        [Required, StringLength(30)]
        public string PhoneNumber { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
