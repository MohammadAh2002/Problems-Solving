/*
 
    User Survey Results
    Task: Store the responses of 5 questions (Yes/No) for a survey.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray surveyResponses = new BitArray(5);

        // User 1 responses: Yes, No, Yes, Yes, No
        surveyResponses[0] = true; 
        surveyResponses[1] = false;
        surveyResponses[2] = true; 
        surveyResponses[3] = true; 
        surveyResponses[4] = false;

        for (int i = 0; i < surveyResponses.Length; i++)
        {

            Console.WriteLine($"User {i + 1}, Question {i + 1}: {surveyResponses[i]}");
        
        }

    }
}
