/*

    Autocomplete Suggestions in a Search Feature
    Description: Implement an autocomplete feature where users type a prefix,
                 and the program suggests words starting with that prefix in alphabetical order.

*/

class Program
{
    static void Main()
    {

        SortedSet<string> Words = new SortedSet<string>
        {
            "apple", "application", "appreciate", "banana", "band", "bandwidth", "cat", "cater"
        };

        Console.Write("Enter a prefix: ");
        string? Prefix = Console.ReadLine();

        IEnumerable<string> Suggestions = GetSuggestions(Words, Prefix);

        Console.WriteLine("Suggestions:");
        foreach (string Word in Suggestions)
        {
            Console.WriteLine(Word);
        }

    }

    static IEnumerable<string> GetSuggestions(SortedSet<string> Words, string? Prefix)
    {
        foreach (string Word in Words)
        {
            if (Word.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase))
            {
                yield return Word;
            }
        }
    }
}
