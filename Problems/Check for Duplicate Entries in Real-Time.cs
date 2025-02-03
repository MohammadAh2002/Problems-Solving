/*
 
    Check for Duplicate Entries in Real-Time
    Problem: Detect duplicates as data is added.

    use: Hashset  
 
*/

class Program
{
    static void Main()
    {

        HashSet<string> Data = new HashSet<string>();

        string[] Entries = { "A", "B", "C", "A" };
        
        foreach (string Entry in Entries)
        {
            if (!Data.Add(Entry))
            {
                Console.WriteLine($"Duplicate Detected: {Entry}");
            }
        }

    }
}
