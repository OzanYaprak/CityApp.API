using AutoMapper;
using CityApp.API.Models;
using CityApp.API.Models.Dto.City;
using CityApp.API.Responces;

namespace CityApp.API.Services.CityService
{
    public class CityService : ICityService
    {
        private static List<City> Cities = new List<City>
        {
            new City(),
            new City(){CityID=1, CityName="Kastamonu", CityPopulation="5000" }
        };


        private readonly IMapper _mapper;

        public CityService(IMapper mapper)
        {
            _mapper = mapper;
        }



        public async Task<ServiceResponse<List<GetCity>>> AddCity(PostCity city)
        {
            var serviceResponse = new ServiceResponse<List<GetCity>>();
            Cities.Add(_mapper.Map<City>(city));

            serviceResponse.Data = Cities.Select(x=>_mapper.Map<GetCity>(x)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCity>>> GetAllCities()
        {
            var serviceResponse = new ServiceResponse<List<GetCity>> { Data = Cities.Select(x => _mapper.Map<GetCity>(x)).ToList() };

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCity>> GetCityByID(int id)
        {
            var serviceResponse = new ServiceResponse<GetCity>();

            var city = Cities.Find(x => x.CityID == id);
            serviceResponse.Data = _mapper.Map<GetCity>(city);

            return serviceResponse;
        }
    }
}