/*

    Real-Time Notification System
    Problem: Display notifications about your order dynamically as they arrive.

*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {

        ObservableCollection<string> Notification = new ObservableCollection<string>();

        Notification.CollectionChanged += (sender, e) =>
        {

            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"New Notification: {e.NewItems[0]}");

        };

        Notification.Add("Your order is under processing.");
        Notification.Add("Your order has been shipped.");
        Notification.Add("Your order is Delivered.");

    }
}
