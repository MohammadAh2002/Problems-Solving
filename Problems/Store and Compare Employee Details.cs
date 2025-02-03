/*
 
    Store and Compare Employee Details
    Problem: Use tuples to store employee names and salaries, and compare them. 
 
*/

class Program
{
    static void Main()
    {

        (string Name, int Salary) Employee1 = ("Mohammad", 15000);
        (string Name, int Salary) Employee2 = ("Ahmad", 1500);

        if (Employee1.Salary > Employee2.Salary)
            Console.WriteLine($"{Employee1.Name} Salary is Bigger");
        else if (Employee2.Salary > Employee1.Salary)
            Console.WriteLine($"{Employee2.Name} Salary is Bigger");
        else
            Console.WriteLine("Salaries is Equal");

    }

    
}
