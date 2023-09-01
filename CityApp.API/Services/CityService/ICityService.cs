using CityApp.API.Models;

namespace CityApp.API.Services.CityService
{
    public interface ICityService
    {
        List<City> GetAllCities();

        City GetCityByID(int id);

        List<City> AddCity(City city);
    }
}