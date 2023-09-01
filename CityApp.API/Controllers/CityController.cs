using CityApp.API.Models;
using CityApp.API.Services.CityService;
using Microsoft.AspNetCore.Mvc;

namespace CityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }




        [HttpGet]
        public ActionResult<List<City>> Get()
        {
            return Ok(_cityService.GetAllCities());
        }

        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            var city = _cityService.GetCityByID(id);
            if (city == null) { return NotFound("Böyle birşey yok"); }
            return Ok(city);
        }

        //[HttpGet]
        //public ActionResult<City> GetSingle()
        //{
        //    return Ok(Cities[0]); //City tablosundaki 0 ncı indeksdeki kaydı getir.
        //}

        [HttpPost]
        public ActionResult<List<City>> Post(City city)
        {
            return Ok(_cityService.AddCity(city));
        }
    }
}

//var regions = Enum.GetNames(typeof(Region)); Enumdan controller'a data çekme işlemi.