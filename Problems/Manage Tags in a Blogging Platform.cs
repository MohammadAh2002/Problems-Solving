/*

    Manage Tags in a Blogging Platform
    Description: In a blogging platform, authors can add tags to their posts.
                 Maintain a list of all unique tags in alphabetical order.

*/

class Program
{
    static void Main()
    {

        SortedSet<string> Tags = new SortedSet<string>
        {

            {"IT"},
            {"Programming"},
            {"C#"},
            {"Football"},
            {"Coding"}

        };

        Console.WriteLine("All Unique Tags (sorted):");
        foreach (string Tag in Tags)
        {
            Console.WriteLine(Tag);
        }

    }
}
