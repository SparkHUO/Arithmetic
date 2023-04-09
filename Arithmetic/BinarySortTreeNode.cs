using System;
using System.Collections.Generic;
using System.Text;


namespace Arithmetic
{
    //二叉排序树
    class BinarySortTreeNode
    {
        public int Key { get; set; }    //每个结点所指代的值
        public BinarySortTreeNode Left { get; set; }
        public BinarySortTreeNode Right { get; set; }
        public BinarySortTreeNode(int key)
        { 
            Key = key;
        }
        public void Insert(int key)
        { 
            var tree = new BinarySortTreeNode(key);
            if (tree.Key <= Key)   //如果比当前插入的结点小，则向当前结点的左子树插入
            {
                if (Left == null)
                {
                    Left = tree;
                }
                else
                {
                    Left.Insert(key);   //递归
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = tree;
                }
                else
                {
                    Right.Insert(key);
                }
            }
        }

        /// <summary>
        /// 中序遍历；
        /// </summary>
        public void IncorderTraversal()
        { 
            Left?.IncorderTraversal();  //递归，直到Left为空时，进行下一句
            Console.Write(Key); //打印结点内容
            Right?.IncorderTraversal();
        }
    }




}
