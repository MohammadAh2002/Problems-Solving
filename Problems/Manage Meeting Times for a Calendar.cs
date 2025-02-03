/*

    Manage Meeting Times for a Calendar
    Description: Automatically organize meeting times chronologically for a daily calendar.
 
*/

class Program
{
    static void Main()
    {

        SortedSet<TimeSpan> MeetingTimes = new SortedSet<TimeSpan>
        {

            new TimeSpan(14, 0, 0),
            new TimeSpan(9, 30, 0),
            new TimeSpan(11, 0, 0)

        };

        Console.WriteLine("Today's meetings (sorted):");
        foreach (TimeSpan Time in MeetingTimes)
        {

            Console.WriteLine(Time.ToString());

        }

    }
}
