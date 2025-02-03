/*
 
    Check If Set Contains Multiple Ranges
    Problem: Check if a SortedSet contains elements from multiple specified ranges.

    Example:
    Input: set = [1, 2, 3, 4, 5], ranges = [(1, 2), (4, 5)]
    Output: True

    Key Points:

    Use GetViewBetween for each range and check if all elements exist.
 
*/

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 3, 4, 5 };

        List<(int, int)> Ranges = new List<(int, int)> { (1, 2), (4, 5) };

        if (ContainsAllRanges(Numbers, Ranges))
            Console.WriteLine("Yes Set Contains Multiple Ranges");
        else
            Console.WriteLine("No Set dose not Contains Multiple Ranges");

    }

    static bool ContainsAllRanges(SortedSet<int> Numbers, List<(int, int)> Ranges)
    {
        foreach ((int Low, int High) in Ranges)
        {

            SortedSet<int> Range = Numbers.GetViewBetween(Low, High);

            if (Range.Count != (High - Low + 1))
                return false;

        }

        return true;

    }

}
