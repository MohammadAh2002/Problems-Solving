/*
 
    Find the Frequency of Each Character
    Problem: Count the frequency of each character in a string.

    Example:
    Input: "hello"
    Output: { 'h': 1, 'e': 1, 'l': 2, 'o': 1 }

    Key Points:

    Use a dictionary to map characters to their frequency.
 
*/

class Program
{
    static void Main()
    {

        string S = "Hello";

        foreach (KeyValuePair<char, int> Item in CharacterFrequency(S)){

            Console.WriteLine("Char: " + Item.Key + ", Frequency: " + Item.Value);

        }

    }

    static public Dictionary<char, int> CharacterFrequency(string S)
    {

        Dictionary<char, int> characters = new Dictionary<char, int>();

        for (int i = 0; i < S.Length; i++) {

            if (characters.ContainsKey(S[i]))
                characters[S[i]]++;
            else
                characters.Add(S[i], 1);

        }

        return characters;

    }

}
