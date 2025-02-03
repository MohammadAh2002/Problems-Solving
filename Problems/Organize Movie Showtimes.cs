/*

    Organize Movie Showtimes
    Description: Store and sort movie showtimes to display the next available slot.
 
*/

class Program
{
    static void Main()
    {

        SortedSet<DateTime> MovieShowtimes = new SortedSet<DateTime>
        {

            new DateTime(2024, 11, 19, 14, 0, 0),
            new DateTime(2024, 11, 19, 12, 30, 0),
            new DateTime(2024, 11, 19, 16, 15, 0)

        };

        Console.WriteLine("Next Showtime: " + MovieShowtimes.Min);

        Console.WriteLine("\nAll Showtimes:");
        foreach (DateTime Time in MovieShowtimes)
        {
            Console.WriteLine(Time.ToShortTimeString());
        }

    }
}
