/*

    Ticketing System Simulation
    Problem: Simulate a ticketing system where customers are served in the order they arrive.
    When a customer’s ticket is processed, the next ticket is queued for service.

    Output:

    Ticket 101 issued.
    Ticket 102 issued.
    Ticket 103 issued.
    Ticket 104 issued.
    Ticket 105 issued.

    Ticketing System Simulation Started...

    Processing Ticket: 101
    Remaining Tickets: 102, 103, 104, 105

    Processing Ticket: 102
    Remaining Tickets: 103, 104, 105

    Processing Ticket: 103
    Remaining Tickets: 104, 105

    Processing Ticket: 104
    Remaining Tickets: 105

    Processing Ticket: 105
    No more tickets in the queue.

    Ticketing System Simulation Ended.

*/

class Program
{
    static void Main()
    {

        Queue<int> TicketsQueue = new Queue<int>();

        // Simulate ticket generation
        for (int i = 101; i <= 105; i++)
        {
            TicketsQueue.Enqueue(i);
            Console.WriteLine($"Ticket {i} issued.");
        }

        Console.WriteLine("\nTicketing System Simulation Started...");

        while (TicketsQueue.Count > 0)
        {

            int TicketProcess = TicketsQueue.Dequeue();
            Console.WriteLine("\nProcessing Ticket: " + TicketProcess);

            if (TicketsQueue.Count > 0)
            {
                Console.WriteLine("Remaining Tickets: " + string.Join(", ", TicketsQueue));
            }
            else
            {
                Console.WriteLine("No more tickets in the queue.");
            }

        }

        Console.WriteLine("\nTicketing System Simulation Ended.");

    }
}
