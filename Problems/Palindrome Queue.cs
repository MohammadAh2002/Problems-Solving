/*

    Palindrome Queue
    Problem: Check if a queue is a palindrome (same forwards and backwards).

    Example:
    
    Input: 
        Queue = [1, 2, 3, 2, 1]
    
    Output:
        True


    Key Points:

    Use a stack to check the reversed order of the queue.
    Compare each dequeued element with the popped stack element. 

 */


class Program
{
    static void Main()
    {

        Queue<int> Queue = new Queue<int>(new[] { 1, 2, 3, 2, 1 });

        if (IsPalindromeQueue(Queue))
            Console.WriteLine("Yes the Queue is Palindrome");
        else
            Console.WriteLine("No the Queue is not Palindrome");
    }

    static bool IsPalindromeQueue(Queue<int> Queue)
    {
        Stack<int> stack = new Stack<int>(Queue);

        foreach (int item in Queue)
        {
            if (stack.Pop() != item)
                return false;
        }

        return true;

    }
}
