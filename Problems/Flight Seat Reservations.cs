/*

    Flight Seat Reservations
    Problem: Store seat availability for multiple flights where each flight has a different number of seats.
 
*/

class Program
{
    static void Main()
    {

        bool[][] SeatAvailable = new bool[2][];
        SeatAvailable[0] = new bool[] { true, false, true };
        SeatAvailable[1] = new bool[] { false, false, true, true };

        Console.WriteLine("Seat Availability:");
        for (int i = 0; i < SeatAvailable.Length; i++)
        {

            Console.Write($"Flight {i + 1}: ");

            Console.WriteLine(string.Join(", ", SeatAvailable[i]));

        }

    }

}
