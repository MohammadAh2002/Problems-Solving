/*

    Directory Size Calculation
    You need to calculate the total size of a directory, including all its files and subdirectories.

*/

class DirectoryNode
{

    public string Name { get; set; } 
    public int Size { get; set; } 
    public List<DirectoryNode> Childrens { get; set; } = new List<DirectoryNode>(); 

    public DirectoryNode(string name, int size)
    {
        Name = name;
        Size = size;
    }

    public int CalculateTotalSize()
    {
        int totalSize = Size; 
        foreach (DirectoryNode child in Childrens)
        {
            totalSize += child.CalculateTotalSize();
        }
        return totalSize;
    }

    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}{Name} (Size: {Size})");
        foreach (DirectoryNode child in Childrens)
        {
            child.Print(indent + "  ");
        }
    }

}



class Program
{
    static void Main()
    {

        DirectoryNode Root = new DirectoryNode("root", 0);
        DirectoryNode Documents = new DirectoryNode("Documents", 0);
        DirectoryNode Photos = new DirectoryNode("Photos", 0);

        Documents.Childrens.Add(new DirectoryNode("Resume.docx", 50));
        Documents.Childrens.Add(new DirectoryNode("Project.pdf", 100));

        Photos.Childrens.Add(new DirectoryNode("Vacation.jpg", 200));

        Root.Childrens.Add(Documents);
        Root.Childrens.Add(Photos);

        Console.WriteLine("Directory Structure:");
        Root.Print();

        Console.WriteLine($"\nTotal size of the directory: {Root.CalculateTotalSize()} bytes");

    }
}
