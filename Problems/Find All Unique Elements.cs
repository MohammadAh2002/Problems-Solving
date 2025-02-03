/*
 
    Find All Unique Elements
    Problem: Return all unique elements from an array.

    Example:
    Input: [1, 2, 2, 3, 4, 5, 3]
    Output: [1, 4, 5]

    Key Points:

    Use a dictionary to track occurrences and filter unique elements.
 
*/

class Program
{
    static void Main()
    {

        int[] Nums = { 1, 2, 2, 3, 4, 5, 3 };

        Console.WriteLine("Unique Elements the the Array: " + string.Join(", ", FindUniqueElements(Nums)));

    }

    static List<int> FindUniqueElements(int[] nums)
    {

        Dictionary<int, int> Counts = new Dictionary<int, int>();

        List<int> Unique = new List<int>();

        foreach (int num in nums)
        {
            if (!Counts.ContainsKey(num))
                Counts[num] = 0;

            Counts[num]++;
        }

        foreach (var kvp in Counts)
        {
            if (kvp.Value == 1)
                Unique.Add(kvp.Key);
        }

        return Unique;

    }
}
