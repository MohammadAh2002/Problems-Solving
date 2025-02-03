/*

    Automatically Sort Event Timelines
    
    Description:
    Maintain a sorted timeline of events by their occurrence times to show the upcoming ones first.
 
*/

class Program
{
    static void Main()
    {

        SortedSet<DateTime> EventTimeline = new SortedSet<DateTime>
        {

            new DateTime(2024, 12, 25),
            new DateTime(2024, 11, 30),
            new DateTime(2025, 1, 1)

        };

        Console.WriteLine("Upcoming Events:");
        foreach (DateTime EventTime in EventTimeline)
        {

            Console.WriteLine(EventTime.ToShortDateString());

        }

    }
}
