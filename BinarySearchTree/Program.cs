using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Welcome to Binary search tree program...");

            Console.WriteLine("\n Adding elements to Binary tree... ");
            BinaryTree<int> bt = new BinaryTree<int>();
            Console.WriteLine("\n Element | Path from root");
            bt.Insert(56);
            bt.Insert(30);
            bt.Insert(70);
            //UC2 : Adding tree elements displayed in the figure
            bt.Insert(22);
            bt.Insert(40);
            bt.Insert(60);
            bt.Insert(95);
            bt.Insert(11);
            bt.Insert(65);
            bt.Insert(3);
            bt.Insert(16);
            bt.Insert(63);
            bt.Insert(67);

            Console.Write("\n Elements Traversal : ");
            bt.Traverse(bt.root);
            bt.SizeOfTree();
            Console.WriteLine("\n");
        }
    }
}
