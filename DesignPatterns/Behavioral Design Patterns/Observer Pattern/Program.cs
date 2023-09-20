namespace Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            IObserver phoneDisplay = new PhoneDisplay();
            IObserver tvDisplay = new TVDisplay();

            weatherStation.RegisterObserver(phoneDisplay);
            weatherStation.RegisterObserver(tvDisplay);

            weatherStation.SetWeatherData("Temperature: 25°C, Humidity: 50%");

            weatherStation.RemoveObserver(phoneDisplay);

            weatherStation.SetWeatherData("Temperature: 30°C, Humidity: 40%");
        }
    }
}