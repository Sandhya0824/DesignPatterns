using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string weatherData;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(weatherData);
            }
        }
        public void SetWeatherData(string data)
        {
            weatherData = data;
            NotifyObservers();
        }
    }
}
