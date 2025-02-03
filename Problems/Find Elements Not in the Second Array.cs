/*
 
    Find Elements Not in the Second Array
    Problem: Find all elements in the first array that are not in the second array.

    Example:
    Input: nums1 = [1, 2, 3, 4], nums2 = [3, 4, 5, 6]
    Output: [1, 2]

    Key Points:

    Use a HashSet to store the second array's elements for quick lookups.
 
*/

class Program
{
    static void Main()
    {

        int[] Numbers1 = { 1, 2, 3, 4 };
        int[] Numbers2 = { 3, 4, 5, 6 };

        Console.WriteLine("Way 1:");
        Console.WriteLine("elements in the first array that are not in the second array: " + string.Join(", ", ElementsNotInSecondArray(Numbers1, Numbers2)));
        Console.WriteLine("_____________________________________________________");

        Console.WriteLine("Way 2:");
        Console.WriteLine("elements in the first array that are not in the second array: " + string.Join(", ", ElementsNotInSecondArray2(Numbers1, Numbers2)));


    }

    static public int[] ElementsNotInSecondArray(int[] Numbers1, int[] Numbers2)
    {

        HashSet<int> Set1 = new HashSet<int>(Numbers1);
        HashSet<int> Set2 = new HashSet<int>(Numbers2);

        Set1.ExceptWith(Set2);
       
        return Set1.ToArray();
    }

    static int[] ElementsNotInSecondArray2(int[] Numbers1, int[] Numbers2)
    {
        HashSet<int> Set = new HashSet<int>(Numbers2);

        List<int> Result = new List<int>();

        foreach (int num in Numbers1)
        {
            if (!Set.Contains(num))
                Result.Add(num);
        }

        return Result.ToArray();
    
    }
}
