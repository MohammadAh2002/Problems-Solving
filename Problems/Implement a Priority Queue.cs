/*

    Implement a Priority Queue
    Problem: Implement a priority queue where elements with higher priority are dequeued first.

    Example:
    Input: Enqueue(10, 1), Enqueue(5, 3), Enqueue(20, 2), Dequeue()
    Output: 5 (highest priority first)

    Key Points:

    Use a sorted data structure like a SortedList or a SortedDictionary to maintain priorities.
    Dequeue elements based on the priority value. 
 
*/

class Program
{
    static void Main()
    {

        PriorityQueue PQ = new PriorityQueue();

        PQ.Enqueue(10, 3);
        PQ.Enqueue(5, 1);
        PQ.Enqueue(20, 2);

        Console.WriteLine(PQ.Dequeue()); 

    }
}

class PriorityQueue
{
    private SortedDictionary<int, Queue<int>> Queue = new SortedDictionary<int, Queue<int>>();

    public void Enqueue(int value, int priority)
    {
        if (!Queue.ContainsKey(priority))
        {
            Queue[priority] = new Queue<int>();
        }

        Queue[priority].Enqueue(value);
    }


    public int? Dequeue()
    {
        if (Queue.Count == 0) return null;

        int highestPriority = Queue.Keys.Min();
        int value = Queue[highestPriority].Dequeue();

        if (Queue[highestPriority].Count == 0)
        {
            Queue.Remove(highestPriority);
        }

        return value;
    }
}


