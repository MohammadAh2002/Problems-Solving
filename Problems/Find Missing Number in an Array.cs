/*
 
    Find Missing Number in an Array
    Problem: Find the missing number in an array of size n containing numbers from 0 to n.

    Example:
    Input: [3, 0, 1]
    Output: 2
 
*/

class Program
{
    static void Main()
    {

        int[] Nums = { 3, 0, 1 };

        Console.WriteLine("the Missing Number is: " + FindMissingNumber(Nums));

    }

    static int FindMissingNumber(int[] Nums)
    {

        for (int i = 0; i <= Nums.Length; i++)
        {

            if (!Nums.Contains(i))
                return i;

        }

        return -1;

    }

}
