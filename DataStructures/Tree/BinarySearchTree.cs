using CodingPractice.DataStructures.Tree.Nodes;
using CodingPractice.DataStructures.Tree;
using System;

namespace CodingPractice.DataStructures.Tree
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode<int> root;

        public void Insert(int item, BinarySearchTreeNode<int> rootNode = null)
        {
            if (rootNode == null)
            {
                root = new BinarySearchTreeNode<int>(item);
            }
            else
            {
                if (item.CompareTo(rootNode.info) < 1)
                {
                    if (rootNode.left == null)
                    {
                        rootNode.left = new BinarySearchTreeNode<int>(item);
                    }
                    else
                    {
                        Insert(item, rootNode.left);
                    }
                }
                else
                {
                    if (rootNode.right == null)
                    {
                        rootNode.right = new BinarySearchTreeNode<int>(item);
                    }
                    else
                    {
                        Insert(item, rootNode.right);
                    }
                }
            }
        }

        public void Find(int item)
        {

        }

        public void Delete(int item)
        {

        }

        public void Print()
        {
            root.Print(textFormat: "(0)", spacing: 2);
        }
    }
}
