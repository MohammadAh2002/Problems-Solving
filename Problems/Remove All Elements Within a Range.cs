/*
 
    Remove All Elements Within a Range
    Problem: Remove all elements within a specified range from a SortedSet.

    Example:
    Input: set = [1, 2, 3, 4, 5], range = [2, 4]
    Output: [1, 5]

    Key Points:

    Use GetViewBetween and Clear to remove the range. 
 
*/


using System.Collections.Generic;

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 3, 4, 5, 6 };

        SortedSet<int> ElementsWithinRange = Numbers.GetViewBetween(2, 4);
        ElementsWithinRange.Clear();

        Console.WriteLine("Elements Less Than 4: " + string.Join(", ", Numbers));

    }

}
