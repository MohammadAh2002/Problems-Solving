/*

    Dynamic Weather Updates
    Problem: Display a dynamic list of weather updates for different cities.

*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {

        ObservableCollection<string> WeatherUpdates = new ObservableCollection<string>();

        WeatherUpdates.CollectionChanged += (sender, e) =>
        {

            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"Weather Update: {e.NewItems[0]}");

        };

        WeatherUpdates.Add("New York: Sunny, 25°C");
        WeatherUpdates.Add("London: Rainy, 15°C");

    }
}
