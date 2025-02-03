/*

    Interleave Queue Elements
    Problem: Interleave the first half of a queue with the second half.

    Example:
    Input: Queue = [1, 2, 3, 4, 5, 6]
    Output: Queue = [1, 4, 2, 5, 3, 6]

    Key Points:

    Split the queue into two halves using a stack.
    Combine the halves back in interleaved order. 

*/


class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

        InterleaveQueue(Queue);
        Console.WriteLine(string.Join(", ", Queue));
        Console.ReadKey();

    }

    static void InterleaveQueue(Queue<int> Queue)
    {

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < Queue.Count / 2; i++)
        {
            stack.Push(Queue.Dequeue());
        }

        while (stack.Count > 0)
        {
            Queue.Enqueue(stack.Pop());
        }

        for (int i = 0; i < Queue.Count / 2; i++)
        {
            Queue.Enqueue(Queue.Dequeue());
        }

        for (int i = 0; i < Queue.Count / 2; i++)
        {
            stack.Push(Queue.Dequeue());
        }

        while (stack.Count > 0)
        {
            Queue.Enqueue(stack.Pop());
            Queue.Enqueue(Queue.Dequeue());
        }

    }
}
