/*
 
    Union of Two SortedSets
    Problem: Find the union of two SortedSet objects.

    Example:
    Input: set1 = [1, 2, 3], set2 = [3, 4, 5]
    Output: [1, 2, 3, 4, 5]

    Key Points:

    Use UnionWith to compute the union.
  
*/

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers1 = new SortedSet<int> { 1, 2, 3 };
        SortedSet<int> Numbers2 = new SortedSet<int> { 3, 4, 5, 6 };

        Console.WriteLine("Union of the Two SortedSets: " + string.Join(", ", Numbers1.Union(Numbers2)));

    }
}
