/*
 
    First Non-Repeating Character in a Stream
    Problem: Given a stream of characters, find the first non-repeating character after each insertion.

    Example:
    Input: "aabc"
    Output: a, -, b, c


    Key Points:

    Use a queue to track the order of characters.
    Use a dictionary to count occurrences.
 
*/

class Program
{
    static void Main()
    {

        FindFirstNonRepeating("aabc");

    }

    static void FindFirstNonRepeating(string Stream)
    {
        Dictionary<char, int> CountMap = new Dictionary<char, int>();
        Queue<char> Queue = new Queue<char>();

        foreach (char C in Stream)
        {
            if (!CountMap.ContainsKey(C))
                CountMap[C] = 0;

            CountMap[C]++;
            Queue.Enqueue(C);

            while (Queue.Count > 0 && CountMap[Queue.Peek()] > 1)
            {
                Queue.Dequeue();
            }

            Console.WriteLine(Queue.Count > 0 ? Queue.Peek() : '-');
        }
    }
}
