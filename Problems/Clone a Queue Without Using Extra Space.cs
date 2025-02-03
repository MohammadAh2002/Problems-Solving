/*

    Clone a Queue Without Using Extra Space
    Problem: Clone a queue such that the original queue remains unchanged.

    Example:
    Input: Queue = [1, 2, 3, 4]
    Output: Clone = [1, 2, 3, 4]
 
*/

using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new[] {1, 2, 3, 4, 5, 6});

        Console.WriteLine("Cloning the Queue: " + string.Join(", ", CloneQueue(Queue)));

    }

    static public Queue<int> CloneQueue(Queue<int> Queue)
    {

        for (int i = 0; i < Queue.Count; i++) {

            Queue.Enqueue(Queue.Dequeue());
        }

        return Queue;

    }

}
