/*

    File System Organization
    You need to design a system to represent a hierarchical file system where directories can contain files or other directories.
    The system should be able to display the structure in a readable format.

    Output:

    File System:

    Directory: root

    Directory: Documents
        - File: Resume.docx
        - File: Project.pdf
    Directory: Photos
        - File: Vacation.jpg
        - File: Diving.jpg
        - File: Family.jpg 

*/

class FileNode
{
    public string Name { get; set; } 
    public bool IsFile { get; set; } 
    public List<FileNode> Childrens { get; set; } = new List<FileNode>();

    public enum enType
    {
        Directory,
        File
    }

    public FileNode(string name, enType fType)
    {
        Name = name;
        IsFile = fType == enType.File ? true : false;
    }

    public void Print(string indent = "")
    {
        Console.WriteLine(indent + (IsFile ? "File: " : "Directory: ") + Name); 
        foreach (FileNode child in Childrens)
        {
            child.Print(indent + "  "); 
        }
    }
}



class Program
{
    static void Main()
    {

        FileNode Root = new FileNode("root", FileNode.enType.Directory);

        FileNode Documents = new FileNode("Documents", FileNode.enType.Directory);
        FileNode Photos = new FileNode("Photos", FileNode.enType.Directory);
        Documents.Childrens.Add(new FileNode("Resume.docx", FileNode.enType.File));
        Documents.Childrens.Add(new FileNode("Project.pdf", FileNode.enType.File));
        Photos.Childrens.Add(new FileNode("Vacation.jpg", FileNode.enType.File));
        Photos.Childrens.Add(new FileNode("Diving.jpg", FileNode.enType.File));
        Photos.Childrens.Add(new FileNode("Family.jpg", FileNode.enType.File));

        Root.Childrens.Add(Documents);
        Root.Childrens.Add(Photos);

        Console.WriteLine("File System:\n");
        Root.Print();

    }
}
