/*

    Shopping Cart for an E-commerce App
    Problem: Maintain a shopping cart where items can be added, removed,
             or replaced, and notify the UI.

*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        ObservableCollection<string> Cart = new ObservableCollection<string>();

        Cart.CollectionChanged += (sender, e) =>
        {
            //this event will be fired on any change (add or remove.

            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"New Item Added: {e.NewItems[0]}");
            if (e.Action == NotifyCollectionChangedAction.Remove)
                Console.WriteLine($"Item Removed: {e.OldItems[0]}");

        };

        Cart.Add("Laptop");
        Cart.Add("Mouse");

        Cart.Remove("Mouse");

    }
}
