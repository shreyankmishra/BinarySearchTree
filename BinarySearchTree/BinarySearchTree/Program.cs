using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree binarySearchTree = new BSTree();
            binarySearchTree.Insert(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
        }
    }
}
