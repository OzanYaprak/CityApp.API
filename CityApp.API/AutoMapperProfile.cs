using AutoMapper;
using CityApp.API.Models;
using CityApp.API.Models.Dto.City;

namespace CityApp.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<City, GetCity>();
            CreateMap<PostCity, City>();
        }
    }
}
