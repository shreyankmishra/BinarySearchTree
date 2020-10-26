using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class TreeNode
    {
        internal int data;
        internal TreeNode leftNode;
        internal TreeNode rightNode;
        public TreeNode(int data)
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }
        public void Insert(int data)
        {
            int rootData = this.data;
            if (data >= rootData)
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(data);
                }
                else
                {
                    rightNode.Insert(data);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(data);
                }
                else
                {
                    leftNode.Insert(data);
                }
            }
        }

        public int Search(int data)
        {
            TreeNode currentNode = this;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return currentNode.data;
                }
                else
                {
                    if (data > currentNode.data)
                    {
                        currentNode = currentNode.rightNode;
                    }
                    else
                    {
                        currentNode = currentNode.leftNode;
                    }
                }
            }
            return 0;
        }
            public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }
            Console.Write(data + "\n");
            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }
    }
}
