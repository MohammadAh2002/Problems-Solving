/*
 
    Count Word Frequencies in a Text
    Problem: Count the frequency of each word in a given text.

    Input: "hello world hello universe"

    Output:

    hello: 2

    world: 1

    ﻿universe: 1
 
*/

class Program
{
    static void Main()
    {

        string S = "hello world hello universe";

        Dictionary<string, int> Words = WordFrequencies(S);

        foreach (KeyValuePair<string, int> Word in Words)
        {

            Console.WriteLine($"{Word.Key}: {Word.Value}");

        }

    }

    static public Dictionary<string, int> WordFrequencies(string S)
    {

        Dictionary<string, int> Words = new Dictionary<string, int>();

        foreach (string Word in S.Split(' '))
        {

            if (Words.ContainsKey(Word))
                Words[Word] += 1;
            else
                Words.Add(Word, 1);

        }

        return Words;

    }

}


