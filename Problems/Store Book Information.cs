/*

    Store Book Information
    Problem: Store information about books (Title, Author) using their ISBN as the key.

    Note: Use Dictionary and Tuple.

    Output:

    ISBN: 978-3-16-148410-0, Title: The Great Gatsby, Author: F. Scott Fitzgerald

    ISBN: 978-1-61-729494-5, Title: C# in Depth, Author: Jon Skeet

*/

class Program
{
    static void Main()
    {

        Dictionary<string, (string Title, string Auther)> Books = new Dictionary<string, (string, string)>();

        Books.Add("978-3-16-148410-0", ("C# in Depth", "Jon Skeet"));
        Books.Add("973-3-16-658410-5", ("C++ in Depth", "Mohammad Ahmad"));
        Books.Add("878-3-16-248110-1", ("SQL in Depth", "Mohammad Ahmad"));

        foreach(KeyValuePair<string, (string Title, string Auther)> Book in Books)
        {

            Console.WriteLine($"ISBN: {Book.Key}, Title: {Book.Value.Title}, Author: {Book.Value.Auther}");

        }

    }
}
