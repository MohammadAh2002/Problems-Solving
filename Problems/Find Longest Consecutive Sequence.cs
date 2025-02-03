/*
 
    Find Longest Consecutive Sequence
    Problem: Find the length of the longest consecutive sequence in an array.

    Example:
    Input: [100, 4, 200, 1, 3, 2]
    Output: 4 (sequence: [1, 2, 3, 4])

    Key Points:

    Use a dictionary (or hash set) to check the existence of elements efficiently. 
 
*/

class Program
{
    static void Main()
    {

        int[] Nums = { 100, 4, 200, 1, 3, 2 };

        Console.WriteLine(LongestConsecutive(Nums));

    }

    static int LongestConsecutive(int[] Nums)
    {
        HashSet<int> Set = new HashSet<int>(Nums);

        int LongestStreak = 0;

        foreach (int Num in Set)
        {
            if (!Set.Contains(Num - 1))
            {
                int currentNum = Num;
                int currentStreak = 1;

                while (Set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                LongestStreak = Math.Max(LongestStreak, currentStreak);
            }
        }

        return LongestStreak;
    }
}
