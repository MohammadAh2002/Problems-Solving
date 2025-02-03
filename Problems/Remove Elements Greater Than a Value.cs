/*
 
    Remove Elements Greater Than a Value
    Problem: Remove all elements from a SortedSet that are greater than a specified value.

    Example:
    Input: set = [1, 2, 3, 4, 5], value = 3
    Output: [1, 2, 3]

    Key Points:

    Use GetViewBetween to create a range and then replace the set.
 
*/

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("Remove Elements Greater Than 3: " + string.Join(", ", Numbers.GetViewBetween(Numbers.Min, 3)));

    }

}
