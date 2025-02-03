/*
 
    Find Words That Can Be Typed Using One Row of Keyboard

    Problem: Return all words that can be typed using one row of a QWERTY keyboard.

    Example:
    Input: ["Hello", "Alaska", "Dad", "Peace"]
    Output: ["Alaska", "Dad"]

*/

using System.Linq;

class Program
{
    static void Main()
    {

        string[] Words = ["Hello", "Alaska", "Dad", "Peace"];

        Console.WriteLine("words that can be typed using one row of a QWERTY keyboard:");
        Console.WriteLine(string.Join(", ", OneRowKeyboardWords(Words)));

    }

    static public string[] OneRowKeyboardWords(string[] Words)
    {

        string[] Rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };

        Dictionary<char, int> CharRow = new Dictionary<char, int>();

        for (int i = 0; i < Rows.Length; i++)
        {
            foreach (char c in Rows[i])
            {
                CharRow[c] = i;
            }
        }

        List<string> result = new List<string>();

        foreach (string word in Words)
        {
            int row = CharRow[char.ToLower(word[0])];
            bool isValid = true;

            foreach (char c in word)
            {
                if (CharRow[char.ToLower(c)] != row)
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
                result.Add(word);
        }

        return result.ToArray();

    }

}
