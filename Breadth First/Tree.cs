using System;
using System.Collections.Generic;


public class Tree<T>
{

    private TreeNode<T> root;
    private int memberCount;
   
	public Tree(T value)
	{
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }

        this.root = new TreeNode<T>(value);
        MemberCount = 1;
	}

    public Tree(T value, params Tree<T>[] children) : this(value)
    {
        foreach(Tree<T> child in children)
        {
            this.root.AddChild(child.root);
            MemberCount += 1;
        }
    }

    public TreeNode<T> Root
    {
        get
        {
            return this.root;
        }
    }

    public int MemberCount { get => memberCount; set => memberCount = value; }

    private void PrintDFS(TreeNode<T> root, string spaces)
    {
        if (this.root == null)
        {
            return;
        }
        Console.WriteLine(spaces + root.Value.ToString());
        TreeNode<T> child = null;

        for (int i = 0; i < root.ChildrenCount; i++)

        {
            child = root.GetChild(i);
            PrintDFS(child, spaces + "   ");
        }
    }


    public void TraverseDFS()
    {
        this.PrintDFS(this.root, string.Empty);
    }

    public void TraverseBFS()
    {
        Queue<TreeNode<T>> que = new Queue<TreeNode<T>>();

        que.Enqueue(root);
        while (que.Count != 0)
        {
            TreeNode<T> node = que.Dequeue();
            if (!node.Visited)
            {
                node.Visited = true;
                // Do Something with visited node.
                Console.WriteLine(node.Value);
                foreach (TreeNode<T> child in node.GetChildren())
                {
                    if (!child.Visited)
                    {
                        que.Enqueue(child);
                    }
                }
            }
        }
    }
}
