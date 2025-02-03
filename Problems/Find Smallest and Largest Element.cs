/*
 
    Find Smallest and Largest Element
    Problem: Find the smallest and largest element in a SortedSet.

    Example:
    Input: [4, 2, 5, 1, 3]
    Output: Smallest: 1, Largest: 5

    Key Points:

    Use Min and Max properties.
 
*/

class Program
{
    static void Main()
    {
        SortedSet<int> Numbers = new SortedSet<int> {1, 2, 3, 4, 5, 6};

        Console.WriteLine("smallest Element is: " + Numbers.Min);
        Console.WriteLine("largest Element is: " + Numbers.Max);

    }
}
