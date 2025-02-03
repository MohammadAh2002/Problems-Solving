/*
 
    Dynamic Skill Matching
    Problem: Match a candidate’s skills to a job’s required skills.

    Input:

    candidateSkills = { "C#", "SQL", "JavaScript" }

    jobRequirements = { "C#", "JavaScript", "React" }

    Output: Matching Skills: C#, JavaScript 
  
*/

class Program
{
    static void Main()
    {

        HashSet<string> CandidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };
        HashSet<string> JobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };

        CandidateSkills.IntersectWith(JobRequirements);

        Console.WriteLine("Matching Skills: " + string.Join(", ", CandidateSkills));

    }
}
