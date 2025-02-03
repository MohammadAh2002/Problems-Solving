/*
 
    Print the largest value at each level of a binary tree.
    Write a program to print the largest value at each level of a binary tree.

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
   
    public void PrintTree(TreeNode root, string indent = "")
    {

        if (root == null) return;

        PrintTree(root.Left, indent + "  "); 
        Console.WriteLine($"{indent}{root.Value}"); 
        PrintTree(root.Right, indent + "  "); 

    }

    public List<int> LargestValuesAtEachLevel(TreeNode root)
    {

        List<int> result = new List<int>();
        if (root == null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
     
        while (queue.Count > 0)
        {

            int levelSize = queue.Count; 
            int maxValue = int.MinValue;
           
            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();
                maxValue = Math.Max(maxValue, node.Value); 

                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }

            result.Add(maxValue); 
        }

        return result;
    }

}

class Program
{
    static void Main(string[] args)
    {

        BinaryTree Tree = new BinaryTree();

        TreeNode Root = new TreeNode(1);
        Root.Left = new TreeNode(3);
        Root.Right = new TreeNode(2);
        Root.Left.Left = new TreeNode(5);
        Root.Left.Right = new TreeNode(3);
        Root.Right.Right = new TreeNode(9);

        Console.WriteLine("Binary Tree:");
        Tree.PrintTree(Root);

        Console.WriteLine("\nLargest Values at Each Level:");
        List<int> largestValues = Tree.LargestValuesAtEachLevel(Root);
        for (int i = 0; i < largestValues.Count; i++)
        {

            Console.WriteLine($"Level {i + 1}: {largestValues[i]}");

        }

    }
}