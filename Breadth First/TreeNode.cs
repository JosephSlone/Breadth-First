using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    private T value;
    private bool visited = false;
    private bool hasParent;
    private List<TreeNode<T>> children;

	public TreeNode(T value)
	{
        if(value == null)
        {
            throw new ArgumentNullException("Cannot insert null value");
        }
        this.value = value;
        this.Children = new List<TreeNode<T>>();
	}

    public T Value
    {
        get
        {
            return this.value;
        }
        set
        {
            this.value = value;
        }
    }

    public bool Visited
    {
        get
        {
            return this.visited;
        }
        set
        {
            this.visited = value;
        }
    }

    public int ChildrenCount
    {
        get { return this.Children.Count; }
    }

    public List<TreeNode<T>> Children { get => children; set => children = value; }

    public void AddChild(TreeNode<T> child)
    {
        if (child == null)
        {
            throw new ArgumentException("Cannont insert null value!");
        }

        if (child.hasParent)
        {
            throw new ArgumentException("The node already has a parent");
        }

        child.hasParent = true;
        this.Children.Add(child);
    }

    public TreeNode<T> GetChild(int index)
    {
        return this.Children[index];
    }

    public List<TreeNode<T>> GetChildren()
    {
        return this.Children;
    }
}
