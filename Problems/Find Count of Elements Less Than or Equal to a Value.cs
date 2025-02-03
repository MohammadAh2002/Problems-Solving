/*
 
    Find Count of Elements Less Than or Equal to a Value
    Problem: Count the number of elements in a SortedSet less than or equal to a given value.

    Example:
    Input: set = [1, 2, 3, 4, 5], value = 3
    Output: 3

    Key Points:

    Use GetViewBetween and check the size of the subset.
 
*/

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("Elements Less Than or Equal to 3: " + ElementsLessThanOrEqual(Numbers, 3));

    }

    static int ElementsLessThanOrEqual(SortedSet<int> Numbers, int Value)
    {
        return Numbers.GetViewBetween(Numbers.Min, Value).Count;
    }

}
