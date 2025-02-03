/*

    Hierarchical Employee Management
    Design a system to represent a company's hierarchy, 
    where each employee has a position and may manage other employees.
    The structure should allow the entire hierarchy to be printed.

    Output:

    Company Hierarchy:

    CEO: Alice
        - VP of Marketing: Bob
    Marketing Manager: Charlie
        - VP of Technology: Lara
        - Architect: Tom

*/
class EmployeeNode
{

    public string Name { get; set; } 
    public string Position { get; set; } 
    public List<EmployeeNode> Subordinates { get; set; } = new List<EmployeeNode>(); 

    public EmployeeNode(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}{Position}: {Name}"); 
        foreach (EmployeeNode subordinate in Subordinates)
        {
            subordinate.Print(indent + "  "); 
        }
    }

}

class Program
{
    static void Main()
    {

        EmployeeNode Ceo = new EmployeeNode("Alice", "CEO");

        EmployeeNode Vp = new EmployeeNode("Bob", "VP of Marketing");
        EmployeeNode Manager = new EmployeeNode("Charlie", "Marketing Manager");

        Vp.Subordinates.Add(Manager); 
        Ceo.Subordinates.Add(Vp);

        Vp = new EmployeeNode("Lara", "VP of Technology");
        Manager = new EmployeeNode("Tom", "Architect");

        Vp.Subordinates.Add(Manager); 
        Ceo.Subordinates.Add(Vp); 

        Console.WriteLine("Company Hierarchy:");
        Ceo.Print();

    }
}
