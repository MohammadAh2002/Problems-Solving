/*

    Sort a Queue
    Problem: Sort elements in a queue in ascending order.

    Example:
    Input: Queue = [5, 1, 3, 2, 4]
    Output: Queue = [1, 2, 3, 4, 5]

    Key Points:

    Convert the queue to a list, sort it, and re-enqueue elements.
 
 */

class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new[] { 5, 1, 3, 2, 4 });

        Console.WriteLine("Queue Before Sorting:");
        Console.WriteLine(string.Join(", ", Queue));

        Queue<int> SortedQueue = SortQueue(Queue);

        Console.WriteLine("Queue After Sorting:");
        Console.WriteLine(string.Join(", ", SortedQueue));

    }

    static Queue<int> SortQueue(Queue<int> Queue)
    {

        List<int> List = new List<int>(Queue);
        List.Sort();

        return new Queue<int>(List);

    }


}
