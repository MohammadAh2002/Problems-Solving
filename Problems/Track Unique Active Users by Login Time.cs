/*

    Track Unique Active Users by Login Time
    Description: Maintain a list of unique active users by their login times,
                 and automatically sort them in chronological order.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        SortedSet<DateTime> ActiveUsers = new SortedSet<DateTime>();

        ActiveUsers.Add(new DateTime(2024, 11, 19, 10, 0, 0));
        ActiveUsers.Add(new DateTime(2024, 11, 19, 10, 15, 0));
        ActiveUsers.Add(new DateTime(2024, 11, 19, 10, 10, 0));

        Console.WriteLine("Active Users Login Times (sorted):");
        foreach (DateTime time in ActiveUsers)
        {

            Console.WriteLine(time);
        
        }

    }
}
