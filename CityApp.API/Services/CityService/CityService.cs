using CityApp.API.Models;

namespace CityApp.API.Services.CityService
{
    public class CityService : ICityService
    {
        private static List<City> Cities = new List<City>
        {
            new City(),
            new City(){CityID=1, CityName="Kastamonu", CityPopulation="5000" }
        };




        public List<City> AddCity(City city)
        {
            Cities.Add(city);
            return Cities;
        }

        public List<City> Get()
        {
            return Cities;
        }

        public City GetCityByID(int id)
        {
            var city = Cities.Find(x => x.CityID == id);
            return city;
        }
    }
}