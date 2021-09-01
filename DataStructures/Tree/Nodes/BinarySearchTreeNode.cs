using System;
using System.Collections.Generic;

namespace CodingPractice.DataStructures.Tree.Nodes
{
    public class BinarySearchTreeNode<T>
    {
        public T info;
        public BinarySearchTreeNode<T> left;
        public BinarySearchTreeNode<T> right;

        public BinarySearchTreeNode(T itemInfo, BinarySearchTreeNode<T> leftNode = null, BinarySearchTreeNode<T> rightNode = null)
        {
            info = itemInfo;
            left = leftNode;
            right = rightNode;
        }
    }
}
