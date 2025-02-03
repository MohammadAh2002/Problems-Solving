/*

    Rearrange Even and Odd Elements
    Problem: Rearrange a queue such that all even numbers appear before odd numbers while maintaining their order.

    Example:
    Input: Queue = [1, 2, 3, 4, 5,6]
    Output: Queue = [2, 4, 6, 1, 3, 5]

    Key Points:

    Use two additional queues to separate even and odd elements.
    Combine them back into the original queue.
 
*/


class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

        Queue<int> RearrangeQueue = RearrangeEvenAndOdd(Queue);

        Console.WriteLine("Rearrange Queue: " + string.Join(", ", RearrangeQueue));

    }

    static public Queue<int> RearrangeEvenAndOdd(Queue<int> Queue)
    {

        Queue<int> OddQueue = new Queue<int>();
        Queue<int> EvenQueue = new Queue<int>();

        while (Queue.Count > 0) {

            if (Queue.Peek() % 2 == 0)
                EvenQueue.Enqueue(Queue.Dequeue());
            else
                OddQueue.Enqueue(Queue.Dequeue());

        }

        return new Queue<int>(EvenQueue.Concat(OddQueue));

    }

}
