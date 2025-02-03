/*
 
    Customer Service Simulation
    Problem: Simulate a customer service system where customers are served in the order they arrive.

    Example:

    Input:
        Customers arriving at different times.

    Output:        
        Serve customers in a first-come, first-served order.
    
    Key Points:

    Use a queue to maintain the order of customer arrivals.
    Dequeue customers when they are served.

 */

class Program
{
    static void Main()
    {

        Queue<string> CustomersQueue = new Queue<string>();

        CustomersQueue.Enqueue("Customer 1");
        CustomersQueue.Enqueue("Customer 2");
        CustomersQueue.Enqueue("Customer 3");

        Console.WriteLine("Serving customers:\n");

        while (CustomersQueue.Count > 0)
        {

            Console.WriteLine("Serving: " + CustomersQueue.Dequeue());

        }

    }
}
