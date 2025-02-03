/*
 
    Reverse a Queue
    Problem: Given a queue, reverse its elements.

    Example:
    Input: Queue = [1, 2, 3, 4, 5]
    Output: Queue = [5, 4, 3, 2, 1]

    Key Points:

    Use a stack to reverse the order of elements in the queue.
    Dequeue all elements into the stack, then re-enqueue them.

*/

class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });

        Console.WriteLine("Queue Before Reverse:");
        Console.WriteLine(string.Join(", ", Queue));

        Queue<int> ReversedQueue = ReverseQueue(Queue);
 
        Console.WriteLine("\nQueue After Reverse:");
        Console.WriteLine(string.Join(", ", ReversedQueue));

    }

    static Queue<int> ReverseQueue(Queue<int> Queue)
    {
        Stack<int> Stack = new Stack<int>();

        while (Queue.Count > 0)
        {
            Stack.Push(Queue.Dequeue());
        }

        while (Stack.Count > 0)
        {
            Queue.Enqueue(Stack.Pop());
        }

        return Queue;
    }

}
