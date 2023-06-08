using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoClub.Controllers
{
    public class VehicleBusinessLogicController : Controller
    {
        private readonly AppDbContext _db;
        public VehicleBusinessLogicController(AppDbContext db)
        {
            _db = db;
        }
        public IQueryable<Vehicle> GetVehicle(VehicleSearchModel vehicleSearchModel)
        {
            var result = _db.Vehicles.AsQueryable().Where(v => v.Blocked == false);
            if (vehicleSearchModel != null)
            {
                if (vehicleSearchModel.Id.HasValue)
                    result = result.Where(x => x.Id == vehicleSearchModel.Id);
                if (vehicleSearchModel.Make.HasValue && vehicleSearchModel.Make != 0)
                    result = result.Where(x => x.VehicleModel.MakeId == vehicleSearchModel.Make);
                if (vehicleSearchModel.Model.HasValue && vehicleSearchModel.Model != 0)
                    result = result.Where(x => x.VehicleModelId == vehicleSearchModel.Model);
                if (!string.IsNullOrEmpty(vehicleSearchModel.Status))
                {
                    if (vehicleSearchModel.Status == "new")
                    {
                        result = result.Where(x => x.Status == "new");
                    }
                    else
                    {
                        result = result.Where(x => x.Status == "used");
                    }
                }
                if (vehicleSearchModel.MinYear.HasValue)
                    result = result.Where(x => x.VehicleManufacturerYear >= vehicleSearchModel.MinYear);
                if (vehicleSearchModel.MaxYear.HasValue)
                    result = result.Where(x => x.VehicleManufacturerYear <= vehicleSearchModel.MaxYear);
                if (vehicleSearchModel.PriceFrom.HasValue)
                    result = result.Where(x => x.Price >= vehicleSearchModel.PriceFrom);
                if (vehicleSearchModel.PriceTo.HasValue)
                    result = result.Where(x => x.Price <= vehicleSearchModel.PriceTo);
                if (vehicleSearchModel.PriceTo.HasValue)
                {
                    if (vehicleSearchModel.BodyType == 1)
                    {
                        result = result.Where(x => x.BodyTypeId == 1);
                    }
                    if (vehicleSearchModel.BodyType == 2)
                    {
                        result = result.Where(x => x.BodyTypeId == 2);
                    }
                    if (vehicleSearchModel.BodyType == 3)
                    {
                        result = result.Where(x => x.BodyTypeId == 3);
                    }
                    if (vehicleSearchModel.BodyType == 4)
                    {
                        result = result.Where(x => x.BodyTypeId == 4);
                    }
                    if (vehicleSearchModel.BodyType == 5)
                    {
                        result = result.Where(x => x.BodyTypeId == 5);
                    }
                    if (vehicleSearchModel.BodyType == 6)
                    {
                        result = result.Where(x => x.BodyTypeId == 6);
                    }
                }
            }
            return result;
        }
    }
}