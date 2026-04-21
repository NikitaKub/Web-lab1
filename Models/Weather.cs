using Newtonsoft.Json;
namespace WEB_02.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
    public class Main
    {
        public float Temp { get; set; }
        [JsonProperty("temp_min")]
        public float TempMin { get; set; }
        [JsonProperty("temp_max")]
        public float TempMax { get; set; }
    }
    public class Wind
    {
        public float Speed { get; set; }
        public int Deg { get; set; }
        public float Gust { get; set; }
    }
    public class WeatherData
    {
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public string Name { get; set; }
    }
}