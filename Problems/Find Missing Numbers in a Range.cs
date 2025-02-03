/*

    Find Missing Numbers in a Range
    Description: Given a range of numbers, find the missing numbers by comparing with a SortedSet.
 
*/

class Program
{
    static void Main()
    {

        SortedSet<int> Numbers = new SortedSet<int> { 1, 2, 4, 5, 7 };

        for (int i = 1; i <= 7; i++)
        {
            if (!Numbers.Contains(i))
            {
                Console.WriteLine($"Missing number: {i}");
            }
        }

    }
}
