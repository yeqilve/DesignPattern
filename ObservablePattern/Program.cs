using System;
using ObservablePattern.Impl;

namespace ObservablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentDisplay currentDisplay = new CurrentDisplay(weatherData);
            weatherData.Set(12, 24);
            Console.Read();
        }
    }
}
