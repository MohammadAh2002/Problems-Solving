/*
 
    Scheduling Tasks
    Task: Represent a weekly schedule with BitArray (7 days). Check which days are free.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray Days = new BitArray(7);

        Days.Set(0, true); // Saturday is free
        Days.Set(6, true); // Friday is free

        for (int i = 0; i < Days.Count; i++)
        {

            Console.WriteLine($"is Day {i + 1}: {Days[i]}");

        }

    }
}
