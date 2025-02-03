/*

    Live Chat Application
    Problem: Display live chat messages in a chat application as they are received.

*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        ObservableCollection<string> Chat = new ObservableCollection<string>();

        Chat.CollectionChanged += (sender, e) =>
        {

            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"New Message: {e.NewItems[0]}");

        };

        Chat.Add("Hi");
        Chat.Add("What You are Doing");

    }
}
