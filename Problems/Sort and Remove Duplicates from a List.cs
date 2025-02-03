/*

    Sort and Remove Duplicates from a List
    Description:
    Given a list with duplicate values, use a SortedSet to remove duplicates and sort it.
 
*/

class Program
{
    static void Main()
    {

        List<int> Numbers = new List<int>(new[] { 1, 1, 2, 6, 8, 4, 6, 3, 3, 1, 5, 7 });

        SortedSet<int> UniqueSortedNumbers = new SortedSet<int>(Numbers);

        Console.WriteLine("Remove Duplicates and Sort the List:");
        Console.WriteLine(string.Join(", ", UniqueSortedNumbers));

    }
}
