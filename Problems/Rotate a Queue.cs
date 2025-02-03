/*
 
    Rotate a Queue
    Problem: Rotate a queue by K positions.

    Example:
    Input: Queue = [1, 2, 3, 4, 5], K = 2
    Output: Queue = [3, 4, 5, 1, 2]

    Key Points:

    Dequeue K elements and enqueue them back.

*/


class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new [] { 1, 2, 3, 4, 5 });

        Console.WriteLine("Queue Before Rotate: " + string.Join(", ", Queue));

        Queue<int> RotatedQueue = RotateQueue(Queue, 2);

        Console.WriteLine("Queue After Rotate: " + string.Join(", ", RotatedQueue));

    }

    static Queue<int> RotateQueue(Queue<int> Queue, int N)
    {

        while (N > 0)
        {

            Queue.Enqueue(Queue.Dequeue());
            N--;

        }

        return Queue;

    }

}
