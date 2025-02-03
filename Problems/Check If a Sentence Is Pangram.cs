/*
  
    Check If a Sentence Is Pangram
    Problem: Check if a sentence contains every letter of the English alphabet at least once.

    Example:


    Input: "The quick brown fox jumps over the lazy dog"
    Output: True

    Key Points:

    Use a HashSet to store unique letters.
 
*/

using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string Sentence = "The quick brown fox jumps over the lazy dog";

        if(IsPangram(Sentence))
            Console.WriteLine("Yes the Sentence is Pangram");
        else
            Console.WriteLine("No the Sentence is not Pangram");

    }

    static public bool IsPangram(string Sentence)
    {

        HashSet<char> Characters = new HashSet<char>();

        foreach (char Character in Sentence.ToLower())
        {

            if(char.IsLetter(Character))
                Characters.Add(Character);

        }

        return Characters.Count == 26;

    }
}
