/*

    Find Middle Element in a Queue
    Problem: Find the middle element of a queue without modifying it.

    Example:
    Input: Queue = [1, 2, 3, 4, 5]
    Output: 3

    Key Points:
    Use a list to access the middle index. 

*/

class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new [] {1, 2, 3, 4, 5, 6});

        Console.WriteLine("Middle Element In The Queue is: " + FindMiddle(Queue));

    }

    static public int FindMiddle(Queue<int> Queue)
    {

        List<int> List = new List<int>(Queue);

        return List[List.Count / 2];
    }

}
