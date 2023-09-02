using CityApp.API.Models;
using CityApp.API.Models.Dto.City;
using CityApp.API.Responces;

namespace CityApp.API.Services.CityService
{
    public interface ICityService
    {
        Task<ServiceResponse<List<GetCity>>> GetAllCities();

        Task<ServiceResponse<GetCity>> GetCityByID(int id);

        Task<ServiceResponse<List<GetCity>>> AddCity(PostCity city);
    }
}