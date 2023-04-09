using System;
using System.Collections.Generic;
using System.Text;

internal class TreeNode
{
    TreeNode Left { get; set; }
    TreeNode Right { get; set; }
    int Value { get; set; }

    public TreeNode(int value,TreeNode left=null,TreeNode right=null)
    { 
        Left = left;
        Right = right;
        Value = value;
    }

    public void Insert(int num)
    {
        if (num<=Value)
        {
            if (Left==null)
            {
                Left = new TreeNode(num);
            }
            else
            {
                Left.Insert(num);
            }
        }
        if (num > Value)
        {
            if (Right == null)
            {
                Right = new TreeNode(num);
            }
            else
            {
                Right.Insert(num);
            }
        }
    }

    public void MiddleSearch()
    {
        Left?.MiddleSearch();

        Console.Write(Value+" ");

        Right?.MiddleSearch();
    }

}
