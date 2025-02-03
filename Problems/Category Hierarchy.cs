/*
 
    Category Hierarchy
    Model a product category hierarchy for an e-commerce platform.

    Output:

    Category Hierarchy:

    Electronics
        - Mobiles
            - Samsung
            - Apple
        - Laptops
            - Lenovo
            - HP

*/

class CategoryNode
{

    public string Name { get; set; }
    public List<CategoryNode> SubCategories { get; set; } = new List<CategoryNode>();

    public CategoryNode(string name)
    {
        Name = name; 
    }
    
    public void Print(string indent = "")
    {
        Console.WriteLine(indent + Name); 
        foreach (CategoryNode subCategory in SubCategories) 
        {
            subCategory.Print(indent + "  "); 
        }
    }

}

class Program

{
    static void Main()
    {

        CategoryNode Root = new CategoryNode("Electronics");
        CategoryNode Mobiles = new CategoryNode("Mobiles"); 
        CategoryNode Laptops = new CategoryNode("Laptops"); 
        CategoryNode Samsung = new CategoryNode("Samsung"); 
        CategoryNode Apple = new CategoryNode("Apple");
        CategoryNode Lenovo = new CategoryNode("Lenovo");
        CategoryNode HP = new CategoryNode("HP");

        Mobiles.SubCategories.Add(Samsung);
        Mobiles.SubCategories.Add(Apple);
        Laptops.SubCategories.Add(Lenovo);
        Laptops.SubCategories.Add(HP);
        Root.SubCategories.Add(Mobiles);
        Root.SubCategories.Add(Laptops);

        Console.WriteLine("Category Hierarchy:");
        Root.Print(); 

    }
}
