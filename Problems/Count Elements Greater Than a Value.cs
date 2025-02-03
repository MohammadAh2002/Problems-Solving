/*
 
    Count Elements Greater Than a Value
    Problem: Count the number of elements greater than a given value in a SortedSet.

    Example:
    Input: set = [1, 2, 3, 4, 5], value = 3
    Output: 2

    Key Points:

    Use GetViewBetween to create a subset. 
 
*/

using System.Collections.Generic;

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("Number Of Elements Greater Than 2: " + NumberOfElementsGreaterThan(Numbers, 2));

    }

    static int NumberOfElementsGreaterThan(SortedSet<int> Numbers, int Value)
    {

        return Numbers.GetViewBetween(Value + 1, Numbers.Max).Count;
    
    }

}
