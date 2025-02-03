/*

    Find Common Characters in Strings
    Problem: Find all common characters between multiple strings.

    Example:
    Input: ["bella", "label", "roller"]
    Output: ["e", "l", "l"]

    Key Points:

    Use a dictionary to track minimum frequency of characters across strings.

*/

class Program
{
    static void Main()
    {

        string[] Words = ["Mohammad", "Ahmad", "Programming"];

        Console.WriteLine("Most Common Characters between the Strings is: " + string.Join(", ", CommonCharacters(Words).Keys));

    }

    static public Dictionary<char, short> CommonCharacters(string[] Words)
    {

        Dictionary<char, short> Chars = new Dictionary<char, short>();

        for (int i = 0; i < Words.Length; i++) {

            foreach (char C in Words[i]) {

                if (Chars.ContainsKey(C))
                    Chars[C]++;
                else
                    Chars.Add(C, 1);

            }

        }

        foreach (KeyValuePair<char, short> C in Chars) { 
        
            if(C.Value < Words.Length)
                Chars.Remove(C.Key);

        }

        return Chars;

    }
}

