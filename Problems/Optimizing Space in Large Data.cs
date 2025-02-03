/*
 
    Optimizing Space in Large Data
    Task: Use BitArray to track which seats (1,000 seats) in a theater are booked.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray Seats = new BitArray(1000, false); 
        Seats[100] = true; 
        Seats[999] = true;

        Console.WriteLine("Seats Info:");

        Console.WriteLine($"Seat 1 booked: {Seats[0]}");
        Console.WriteLine($"Seat 101 booked: {Seats[100]}"); 
        Console.WriteLine($"Seat 1000 booked: {Seats[999]}");
        Console.WriteLine($"Seat 500 booked: {Seats[499]}");

    }
}
