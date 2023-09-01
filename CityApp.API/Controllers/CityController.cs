using CityApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        //var regions = Enum.GetNames(typeof(Region)); Enumdan controller'a data çekme işlemi.


        private static List<City> Cities = new List<City>
        {
            new City(),
            new City(){CityID=1, CityName="Kastamonu", CityPopulation="5000" }
        };

        [HttpGet]
        public ActionResult<List<City>> Get()
        {
            return Ok(Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            var city = Cities.Find(x => x.CityID == id);
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
            Cities.Add(city);
            return Ok(Cities);
        }
    }
}