/*

    Manage Unique Flight Times
    Description: Organize flight times for a day in chronological order without duplicates.

*/

class Program
{
    static void Main()
    {

        SortedSet<DateTime> FlightTimes = new SortedSet<DateTime>
        {

            new DateTime(2024, 11, 19, 8, 0, 0),
            new DateTime(2024, 11, 19, 12, 45, 0),
            new DateTime(2024, 11, 19, 8, 0, 0) // Duplicate, won't be added

        };

        Console.WriteLine("Flight Times (sorted):");
        foreach (DateTime Time in FlightTimes)
        {
            Console.WriteLine(Time.ToShortTimeString());
        }

    }
}
