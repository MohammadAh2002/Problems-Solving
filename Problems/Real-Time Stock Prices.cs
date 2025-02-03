/*

    Real-Time Stock Prices
    Problem: Display a list of real-time stock prices that update dynamically.

*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        ObservableCollection<string> StockPrices = new ObservableCollection<string>();

        StockPrices.CollectionChanged += (sender, e) =>
        {

            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"New Stock Price Added: {e.NewItems[0]}");

        };

        StockPrices.Add("AAPL: 150.00");
        StockPrices.Add("MSFT: 240.50");

    }
}
