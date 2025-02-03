/*
 
    Check if Two Arrays are Disjoint
    Problem: Determine if two arrays have no common elements.

    Example:
    Input: nums1 = [1, 2, 3], nums2 = [4, 5, 6]
    Output: True

    Key Points:

    Use a HashSet to check for common elements. 
 
*/



class Program
{
    static void Main()
    {

        int[] Numbers1 = { 1, 2, 3 };
        int[] Numbers2 = { 4, 5, 6 };

        if (IsArraysHaveNoCommonElements(Numbers1, Numbers2))
            Console.WriteLine("The Arrays don't Have Any Common Element");
        else
            Console.WriteLine("The Arrays Have Common Elements");

    }

    static public bool IsArraysHaveNoCommonElements(int[] Numbers1, int[] Numbers2)
    {

        HashSet<int> Set1 = new HashSet<int>(Numbers1);
        HashSet<int> Set2 = new HashSet<int>(Numbers2);

        Set1.IntersectWith(Set2);

        return Set1.Count == 0;
    }
   
}

