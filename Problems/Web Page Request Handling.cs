/*

    Web Page Request Handling
    Problem: Simulate a web server that processes requests in the order they arrive.

    Example:

    Input:
        Requests arriving at times [Request1, Request2, Request3].
    
    Output:
        Process the requests in the order they arrive.
    
    Key Points:

    Enqueue requests as they arrive.
    Dequeue and process requests in FIFO order.

 */

class Program
{
    static void Main()
    {

        Queue<string> RequestsQueue = new Queue<string>();
        RequestsQueue.Enqueue("Request 1");
        RequestsQueue.Enqueue("Request 2");
        RequestsQueue.Enqueue("Request 3");

        Console.WriteLine("Processing web requests:\n");

        while (RequestsQueue.Count > 0)
        {
            Console.WriteLine("Processed: " + RequestsQueue.Dequeue());
        }

    }
}
