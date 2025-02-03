/*
 
    Voting System
    Task: Use a BitArray to record votes (yes/no) for a decision in a committee of 8 members.
          Count the number of "yes" votes.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray Votes = new BitArray(new bool[] { true, false, true, true, false, false, true, true });

        short YesVotes = 0;
        foreach (bool Vote in Votes)
        {

            if (Vote)
                YesVotes++;

        }

        Console.WriteLine("Number of Yes Votes: {0}", YesVotes);

    }
}
