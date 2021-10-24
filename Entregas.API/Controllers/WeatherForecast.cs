using System;

namespace Entregas.API.Controllers
{
    public class WeatherForecast
    {
        public string Summary { get; internal set; }
        public int TemperatureC { get; internal set; }
        public DateTime Date { get; internal set; }
    }
}