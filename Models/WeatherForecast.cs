using System;

namespace Webtest.Models 
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public double Sunshine { get; set; }

        public double CloudCoverage { get; set; }

        public string Summary { get; set; }

        public int SolarEnergy => (int)(CloudCoverage / 100 * Sunshine * 200);
    }
}
