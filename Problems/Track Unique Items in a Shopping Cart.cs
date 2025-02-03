/*

    Track Unique Items in a Shopping Cart
    Description: Keep track of unique items in a shopping cart and sort them alphabetically.

*/

class Program
{
    static void Main()
    {

        SortedSet<string> ShoppingCart = new SortedSet<string>
        {

            {"Laptop"},
            {"Computer"},
            {"Mouse"}

        };

        Console.WriteLine("Shopping Cart Items (sorted):");
        foreach (string Item in ShoppingCart)
        {

            Console.WriteLine(Item);

        }

    }
}
