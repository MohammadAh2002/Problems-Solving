/*

    Find Numbers Disappeared in an Array
    Problem: Find all numbers missing from the range 1 to n in an array.

    Example:
    Input: [4, 3, 2, 7, 8, 2, 3, 1]
    Output: [5, 6]

*/

class Program
{
    static void Main()
    {

        int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

        Console.WriteLine("Missing Numbers in Array: " + string.Join(", ", FindDisappearedNumbers(nums)));

    }

    static List<int> FindDisappearedNumbers(int[] nums)
    {

        List<int> Result = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {

            if (!nums.Contains(i))
                Result.Add(i);

        }

        return Result;
    }
}
