/*

    Rearrange Queue Alternately
    Problem: Rearrange elements in a queue alternately in increasing and decreasing order.

    Example:
    Input: Queue = [1, 2, 3, 4, 5, 6]
    Output: Queue = [1, 6, 2, 5, 3, 4]
    Key Points:

    Split the queue into two halves.
    Merge the halves alternately. 

*/

class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

        Queue<int> RearrangedQueue = RearrangeQueueAlternately(Queue);

        Console.WriteLine(string.Join(", ", RearrangedQueue)); 

    }

    static public Queue<int> RearrangeQueueAlternately(Queue<int> Queue)
    {

        List<int> List = new List<int>(Queue);
        int N = List.Count;
        Queue<int> Result = new Queue<int>();

        for (int i = 0; i < N / 2; i++)
        {
            Result.Enqueue(List[i]);
            Result.Enqueue(List[N - i - 1]);
        }

        if (N % 2 != 0)
        {
            Result.Enqueue(List[N / 2]);
        }

        return Result;

    }
}
