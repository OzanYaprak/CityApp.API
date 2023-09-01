using System.ComponentModel.DataAnnotations;

namespace CityApp.API.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string CityPopulation { get; set; }

        public Region Region { get; set; } = Region.Karadeniz;
    }
}
