/*
 
   Determine if given Two Trees are Identical or not?
   Write a Program to Determine if given Two Trees are Identical or not.
    
*/

class TreeNode
{

    public int Value { get; set; }
    public TreeNode Left { get; set; } 
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {

        Value = value;
    
    }

}

class BinaryTree
{

    public bool AreIdentical(TreeNode root1, TreeNode root2)
    {

        if (root1 == null && root2 == null) return true;

        if (root1 == null || root2 == null) return false;

        return root1.Value == root2.Value
            && AreIdentical(root1.Left, root2.Left)
            && AreIdentical(root1.Right, root2.Right);

    }

    public void PrintTree(TreeNode root, string indent = "")
    {

        if (root == null) return;

        PrintTree(root.Left, indent + "  ");
        Console.WriteLine($"{indent}{root.Value}");
        PrintTree(root.Right, indent + "  ");

    }

}

class Program
{
    static void Main()
    {

        BinaryTree Tree = new BinaryTree();

        TreeNode Root1 = new TreeNode(1);
        Root1.Left = new TreeNode(2);
        Root1.Right = new TreeNode(3);
        Root1.Left.Left = new TreeNode(4);
        Root1.Left.Right = new TreeNode(5);

        TreeNode Root2 = new TreeNode(1);
        Root2.Left = new TreeNode(2);
        Root2.Right = new TreeNode(3);
        Root2.Left.Left = new TreeNode(4);
        Root2.Left.Right = new TreeNode(5);

        // Print both trees
        Console.WriteLine("Tree 1:");
        Tree.PrintTree(Root1);

        Console.WriteLine("\nTree 2:");
        Tree.PrintTree(Root2);

        // Check if the two trees are identical
        Console.WriteLine("\nAre the two trees identical?");
        Console.WriteLine(Tree.AreIdentical(Root1, Root2)
            ? "Yes, the trees are identical."
            : "No, the trees are not identical.");


        // Create a third tree (not identical)
        TreeNode Root3 = new TreeNode(1);
        Root3.Left = new TreeNode(2);
        Root3.Right = new TreeNode(4);

        Console.WriteLine("\nTree 3:");
        Tree.PrintTree(Root3);

        // Check if the first and third trees are identical
        Console.WriteLine("\nAre Tree 1 and Tree 3 identical?");
        Console.WriteLine(Tree.AreIdentical(Root1, Root3)
            ? "Yes, the trees are identical."
            : "No, the trees are not identical.");

    }
}
