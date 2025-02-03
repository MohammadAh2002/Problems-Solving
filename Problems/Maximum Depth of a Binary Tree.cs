/*
 
    Maximum Depth of a Binary Tree
    Calculate the maximum depth (or height) of a binary tree.

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

    public int MaxDepth(TreeNode root)
    {

        if (root == null) return 0;

        int leftDepth = MaxDepth(root.Left);
        int rightDepth = MaxDepth(root.Right);

        return Math.Max(leftDepth, rightDepth) + 1;

    }

}

class Program
{
    static void Main()
    {

        BinaryTree Tree = new BinaryTree();

        TreeNode Root = new TreeNode(1);
        Root.Left = new TreeNode(2);
        Root.Right = new TreeNode(3);
        Root.Left.Left = new TreeNode(4);
        Root.Left.Right = new TreeNode(5);

        Console.WriteLine($"Maximum Depth: {Tree.MaxDepth(Root)}");

    }
}
