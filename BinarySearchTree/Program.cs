using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Welcome to Binary search tree program...");

            Console.WriteLine("\n Adding 56, 30 and 70 to binary tree. ");
            BinaryTree<int> bt = new BinaryTree<int>();

            Console.WriteLine("\n Root : 56 ");
            bt.Insert(56);
            bt.Insert(30);
            bt.Insert(70);
            Console.Write("\n Elements : ");
            bt.Traverse(bt.root);
            Console.WriteLine("\n");
        }
    }
}
