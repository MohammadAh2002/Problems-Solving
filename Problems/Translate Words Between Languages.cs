/*

    Translate Words Between Languages
    Problem: Create a dictionary for translating words from one language to another.

    Output:

    Hello in Spanish: Hola

    Goodbye in Spanish: Adiós
  
*/


class Program
{
    static void Main()
    {

        Dictionary<string, string> EnglishSpanishWords = new Dictionary<string, string> {

            {"Hello","Hola"},
            {"World", "Mundo"},
            {"Goodbye","Adiós"}

        };

        foreach (KeyValuePair<string, string> Word in EnglishSpanishWords)
        {

            Console.WriteLine(Word.Key + " in Spanish: " + Word.Value);

        }

    }
}
