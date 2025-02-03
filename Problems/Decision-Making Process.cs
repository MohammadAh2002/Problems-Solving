/*
 
    Decision-Making Process
    Create a decision tree for a simple yes/no quiz to recommend a type of pet based on answers to questions.

*/

class DecisionNode
{

    public string Question { get; set; } 
    public DecisionNode Yes { get; set; } 
    public DecisionNode No { get; set; } 

    public DecisionNode(string question)
    {
        Question = question;
    }

}
class Program
{
    static void Main()
    {

        // Build the decision tree manually
        DecisionNode Root = new DecisionNode("Do you like active pets?");
        Root.Yes = new DecisionNode("Do you have a lot of space?");
        Root.Yes.Yes = new DecisionNode("Recommended: Dog"); 
        Root.Yes.No = new DecisionNode("Recommended: Cat"); 
        Root.No = new DecisionNode("Do you prefer low-maintenance pets?");
        Root.No.Yes = new DecisionNode("Recommended: Fish"); 
        Root.No.No = new DecisionNode("Recommended: Hamster"); 

        DecisionNode CurrentNode = Root;

        while (CurrentNode.Yes != null && CurrentNode.No != null)
        {
            Console.WriteLine(CurrentNode.Question); 
            string Answer = Console.ReadLine().Trim().ToLower();
         
            if (Answer == "yes")
                CurrentNode = CurrentNode.Yes;
            else if (Answer == "no")
                CurrentNode = CurrentNode.No;
            else
                Console.WriteLine("Please answer 'yes' or 'no'.");
        }

        Console.WriteLine(CurrentNode.Question);

    }
}
