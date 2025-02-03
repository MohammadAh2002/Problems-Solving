/*
 
    Manage Reserved Seats in a Theater

    Description: In a theater booking system, keep track of reserved seat numbers,
                 ensuring no duplicates and ordered seat numbers.

*/

class Program
{

    static void Main()
    {

        SortedSet<int> ReservedSeats = new SortedSet<int> { 10, 20, 30 };

        ReservedSeats.Add(25);

        if (!ReservedSeats.Add(10))
        {
            // Duplicate, won't be added
            Console.WriteLine("\nSeat 10 is already reserved!\n");

        };

        Console.WriteLine("Reserved Seats:");
        foreach (int seat in ReservedSeats)
        {
            Console.WriteLine("Seat " + seat);
        }

    }

}
