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
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            binarySearchTree.Display();
            Console.WriteLine("Size of BST is : " + binarySearchTree.Size());
            Console.WriteLine("Element " + binarySearchTree.Search(63) + " found in BST");
        }
    }
}
