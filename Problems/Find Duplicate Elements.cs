/*
 
    Find Duplicate Elements
    Problem: Identify duplicate elements in an array.

    Example:
    Input: [1, 2, 3, 4, 2, 5, 6, 1]
    Output: [1, 2]

    Key Points:

    Use a dictionary to count occurrences and collect duplicates.
 
*/

class Program
{
    static void Main()
    {

        int[] Nums = { 1, 2, 3, 4, 2, 5, 6, 1 };

        Console.WriteLine("Duplicate Number in the Array: " + string.Join(", ", FindDuplicates(Nums)));

    }

    static List<int> FindDuplicates(int[] nums)
    {

        Dictionary<int, int> Counts = new Dictionary<int, int>();

        List<int> Duplicates = new List<int>();

        foreach (int num in nums)
        {
            if (Counts.ContainsKey(num))
            {

                Duplicates.Add(num);

            }
            else
            {

                Counts[num] = 1;

            }
        }

        return Duplicates;

    }

}
