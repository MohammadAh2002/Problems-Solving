/*
 
    Find Elements in a Range
    Problem: Find all elements in a SortedSet within a given range [low, high].

    Example:
    Input: set = [1, 2, 3, 4, 5], low = 2, high = 4
    Output: [2, 3, 4]

    Key Points:

    Use GetViewBetween to get a subset within the range.
 
*/

using System.Collections.Generic;

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int>{ 1, 2, 3, 4, 5 };

        Console.WriteLine("Way 1:");
        Console.WriteLine("Elements in a Range 2 to 4: " + string.Join(", ", ElementsInRange(2,4)));
        Console.WriteLine("__________________________________________________________");

        Console.WriteLine("\nWay 2:");
        SortedSet<int> Range = Numbers.GetViewBetween(2, 4);
        Console.WriteLine("Elements in a Range 2 to 4: " + string.Join(", ", Range));

    }

    static public SortedSet<int> ElementsInRange(int Low, int High)
    {

        SortedSet<int> Numbers = new SortedSet<int>();

        for (int i = Low; i <= High; i++) {

            Numbers.Add(i);

        }

        return Numbers;

    }
}
