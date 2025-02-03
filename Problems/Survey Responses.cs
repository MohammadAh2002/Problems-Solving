/*

    Survey Responses
    Problem: Store survey responses where each respondent answers a different number of questions.
 
*/

class Program
{
    static void Main()
    {

        string[][] Survey = new string[3][];
        Survey[0] = new string[] { "Yes", "No" };
        Survey[1] = new string[] { "No", "Yes", "Yes" };
        Survey[2] = new string[] { "Yes" };

        Console.WriteLine("Survey Responses:");
        for (int i = 0; i < Survey.Length; i++)
        {

            Console.Write($"Respondent {i + 1}: ");

            Console.WriteLine(string.Join(", ", Survey[i]));

        }

    }

}
