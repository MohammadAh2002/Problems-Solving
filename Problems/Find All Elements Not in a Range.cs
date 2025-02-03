/*
 
    Find All Elements Not in a Range
    Problem: Find all elements in a SortedSet that are outside a given range [low, high].

    Example:
    Input: set = [1, 2, 3, 4, 5], range = [2, 4]
    Output: [1, 5]

    Key Points:

    Use GetViewBetween and remove the range from the set. 
 
*/


class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Elements Not in a Range: " + string.Join(", ", ElementsNotInRange(Numbers, 2, 4)));

    }

    static IEnumerable<int> ElementsNotInRange(SortedSet<int> Numbers, int Low, int High)
    {

        SortedSet<int> Range = Numbers.GetViewBetween(Low, High);

        SortedSet<int> Result = new SortedSet<int>(Numbers);

        Result.ExceptWith(Range);

        return Result;

    }

}
