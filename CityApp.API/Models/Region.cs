using System.Text.Json.Serialization;

namespace CityApp.API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //1,2,3,4 GELEN YERLERİ BU SATIR SAYESİNDE STRING GÖRÜNECEK
    public enum Region
    {
        Marmara = 1,
        Ege = 2,
        Akdeniz = 3,
        Karadeniz = 4
    }
}
