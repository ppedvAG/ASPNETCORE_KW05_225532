using Microsoft.AspNetCore.Mvc;
using RazorPages_Part2.Models;

namespace RazorPages_Part2.ViewComponents
{
    public class WeatherWidgetViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string cityName)
        {
            WeatherInfo response = await GetWeatherInfo(cityName);
            return View(response);
        }

        private async Task<WeatherInfo> GetWeatherInfo(string cityName)
        {
            WeatherInfo obj = new();

            obj.City = cityName;
            obj.Date = DateTime.Now.ToString("dddd:h:mm tt");

            if (cityName == "London")
            {
                obj.Icon = "sunny.png";
                obj.Condition = "Sunny";
                obj.Precipitation = "7%";
                obj.Humidity = "70%";
                obj.Wind = "6 km/h";
            }
            else if (cityName == "New York")
            {
                obj.Icon = "partly_cloudy.png";
                obj.Condition = "Partly Cloudy";
                obj.Precipitation = "17%";
                obj.Humidity = "80%";
                obj.Wind = "16 km/h";
            }
            else if (cityName == "Paris")
            {
                obj.Icon = "rain.png";
                obj.Condition = "Rain";
                obj.Precipitation = "67%";
                obj.Humidity = "20%";
                obj.Wind = "9 km/h";
            }
            else if (cityName == "Berlin")
            {
                obj.Icon = "sunny.png";
                obj.Condition = "Sunny";
                obj.Precipitation = "5%";
                obj.Humidity = "70%";
                obj.Wind = "9 km/h";
            }

            return obj;
        }
    }
}
