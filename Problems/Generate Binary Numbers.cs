/*

    Generate Binary Numbers
    Problem: Generate binary numbers from 1 to N using a queue.

    Example:
    
    Input:
        N = 5
    
    Output:
        ["1", "10", "11", "100", "101"]


    Key Points:
    Use a queue to store the binary numbers.
    Generate numbers by appending '0' and '1' to the front number. 

 */

class Program
{
    static void Main()
    {

        GenerateBinaryNumbers(5);

    }

    static void GenerateBinaryNumbers(int n)
    {

        Queue<string> NumbersQueue = new Queue<string>();

        NumbersQueue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {

            string binary = NumbersQueue.Dequeue();

            Console.WriteLine(binary);

            NumbersQueue.Enqueue(binary + "0");
            NumbersQueue.Enqueue(binary + "1");

        }

    }
}
