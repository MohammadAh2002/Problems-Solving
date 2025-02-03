/*
 
    Find Elements Less Than a Value
    Problem: Find all elements in a SortedSet less than a given value.

    Example:
    Input: set = [1, 2, 3, 4, 5], value = 4
    Output: [1, 2, 3]

    Key Points:

    Use GetViewBetween to get a subset.
 
*/

using System.Collections.Generic;

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("Elements Less Than 4: " + string.Join(", ", ElementsLessThan(Numbers, 4)));

    }

    static IEnumerable<int> ElementsLessThan(SortedSet<int> Numbers, int Value)
    {
        return Numbers.GetViewBetween(Numbers.Min, Value - 1);
    }

}
