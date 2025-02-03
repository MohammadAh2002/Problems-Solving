/*

    Merge Two Sorted Queues
    Problem: Merge two sorted queues into a single sorted queue.

    Example:
    Input: Queue1 = [1, 3, 5], Queue2 = [2, 4, 6]
    Output: Merged Queue = [1, 2, 3, 4, 5, 6]


    Key Points:

    Use two queues and merge their elements in sorted order.
    Compare the front elements and enqueue the smaller one. 

*/


using System.Globalization;

class Program
{
    static void Main()
    {

        Queue<int> Queue1 = new Queue<int>(new[] { 1, 3, 5 });
        Queue<int> Queue2 = new Queue<int>(new[] { 2, 4, 6 });

        Console.WriteLine("Merged Queue: " + String.Join(", ", MergeSortedQueues(Queue1, Queue2)));

    }

    static Queue<int> MergeSortedQueues(Queue<int> Queue1, Queue<int> Queue2)
    {
        Queue<int> MergeQueue = new Queue<int>();

        while (Queue1.Count > 0 && Queue2.Count > 0)
        {
            if (Queue1.Peek() <= Queue2.Peek())
                MergeQueue.Enqueue(Queue1.Dequeue());
            else
                MergeQueue.Enqueue(Queue2.Dequeue());
        }

        while (Queue1.Count > 0)
        {
            MergeQueue.Enqueue(Queue1.Dequeue());
        }

        while (Queue2.Count > 0)
        {
            MergeQueue.Enqueue(Queue2.Dequeue());
        }

        return MergeQueue;

    }

}
