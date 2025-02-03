/*
 
    File Permission System
    Model a file permission system where each file or folder can inherit permissions from its parent. Use a tree to represent the hierarchy.

    Note: if node is added with empty permission, it will inherit permissions from parent, as you see on the output below Folder2, and File1 inherited permissions form their parents, while others are given permission at creation time.

    Output:

    File Permissions:

    Root: rwx
        Folder1: rw-
            File1: rw-
        Folder2: rwx
            File2: r--

*/

class PermissionNode
{

    public string Name { get; set; }
    public string Permissions { get; set; } 
    public List<PermissionNode> Childrens { get; set; } = new List<PermissionNode>();

    public PermissionNode(string name, string permissions)
    {
        Name = name;
        Permissions = permissions;
    }

    public void PrintPermissions(string inheritedPermissions = "", string indent = "")
    {
        
        string effectivePermissions = Permissions == "" ? inheritedPermissions : Permissions;

        Console.WriteLine($"{indent}{Name}: {effectivePermissions}");

        foreach (PermissionNode child in Childrens)
        {
            child.PrintPermissions(effectivePermissions, indent + "  "); 
        }

    }

}

class Program
{
    static void Main()
    {

        PermissionNode Root = new PermissionNode("Root", "rwx"); 
        PermissionNode Folder1 = new PermissionNode("Folder1", "rw-"); 
        PermissionNode Folder2 = new PermissionNode("Folder2", ""); 
        PermissionNode File1 = new PermissionNode("File1", ""); 
        PermissionNode File2 = new PermissionNode("File2", "r--"); 

        Root.Childrens.Add(Folder1);
        Root.Childrens.Add(Folder2);
        Folder1.Childrens.Add(File1);
        Folder2.Childrens.Add(File2);

        Console.WriteLine("File Permissions:");
        Root.PrintPermissions();

    }
}
