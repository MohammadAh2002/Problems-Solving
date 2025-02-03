/*

    Task Management System
    Problem: Manage a list of tasks dynamically, allowing addition, removal, and status updates.

*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        ObservableCollection<string> Tasks = new ObservableCollection<string>();

        Tasks.CollectionChanged += (sender, e) =>
        {

            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"New Task Added: {e.NewItems[0]}");

            if (e.Action == NotifyCollectionChangedAction.Remove)
                Console.WriteLine($"Task Removed: {e.OldItems[0]}");

        };

        Tasks.Add("Study");
        Tasks.Add("Complete report");

        Tasks.Remove("Complete report");

    }
}
