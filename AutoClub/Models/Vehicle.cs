using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        //public int MakeId { get; set; }
        public int VehicleModelId { get; set; }
        [Required]
        public DateTime ManufacturerYear { get; set; }
        public int VehicleManufacturerYear { get; set; }
        public int BodyTypeId { get; set; }
        [Required]
        public int NoOfSeats { get; set; }
        [Required]
        public int NoOfDoors { get; set; }
        public int TransmissionTypeId { get; set; }
        public int DriveTypeId { get; set; }
        [Required]
        public int NoOfCylinders { get; set; }
        [Required]
        public int EngineCapacity { get; set; }
        public int FuelTypeId { get; set; }
        [Required, StringLength(20)]
        public string Status { get; set; }
        [Required]
        public int CityFuelEconomy { get; set; }
        [Required]
        public int HwyFuelEconomy { get; set; }

        public int VehicleFeaturesId { get; set; }

        [StringLength(300)]
        public string VideoLink { get; set; }
        [Required, StringLength(1500), MinLength(20, ErrorMessage = "You must enter at least 20 characters")]
        public string Description { get; set; }

        [Required,Column(TypeName ="decimal")]
        public decimal Price { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required, StringLength(20)]
        public string ExteriorColor { get; set; }
        [Required, StringLength(20)]
        public string InteriorColor { get; set; }
        public bool Registration { get; set; }
        [StringLength(10)]
        public string RegistrationPlateNumber { get; set; }
        [StringLength(20)]
        public string RegistrationNumber { get; set; }
        [StringLength(20)]
        public string RegistrationExpiryMonth { get; set; }
        public int RegistrationExpiryYear { get; set; }
        [Required, StringLength(255)]
        public string CurrentAddress { get; set; }
        [Required, StringLength(80)]
        public string City { get; set; }
        [StringLength(20)]
        public string ZipCode { get; set; }
        [Required, StringLength(30)]
        public string PhoneNumber { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool PlanType { get; set; }
        [StringLength(10)]
        public string CupunCode { get; set; }

        public bool QuotePrice { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Blocked { get; set; }

        public string AppUserId { get; set; }


        //public virtual Make Make { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        public virtual BodyType BodyType { get; set; }
        public virtual TransmissionType TransmissionType { get; set; }
        public virtual DriveType DriveType { get; set; }
        public virtual FuelType FuelType { get; set; }
        public virtual VehicleFeatures VehicleFeatures { get; set; }
        public virtual IEnumerable<VehicleImage> VehicleImages { get; set; }

        [NotMapped]
        public List<IFormFile> Photos { get; set; }
    }
}