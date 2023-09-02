using CityApp.API.Models;
using CityApp.API.Models.Dto.City;
using CityApp.API.Responces;
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
        public async Task<ActionResult<ServiceResponse<List<GetCity>>>> Get()
        {
            return Ok(await _cityService.GetAllCities());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCity>>> Get(int id)
        {
            var city = await _cityService.GetCityByID(id);
            if (city == null) { return NotFound("Böyle birşey yok"); }
            return Ok(city);
        }

        //[HttpGet]
        //public ActionResult<City> GetSingle()
        //{
        //    return Ok(Cities[0]); //City tablosundaki 0 ncı indeksdeki kaydı getir.
        //}

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCity>>>> Post(PostCity city)
        {
            return Ok(await _cityService.AddCity(city));
        }
    }
}

//var regions = Enum.GetNames(typeof(Region)); Enumdan controller'a data çekme işlemi.