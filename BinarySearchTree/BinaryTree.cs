using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        int treeSize =0;

        public Node<T> root;
        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int element)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = element;
            Console.Write("\n  " +element+ " \t ");
            if (root == null)
            { 
                root = newNode;
                Console.Write(" Root ");
                treeSize++;
            }
            else
            {
                Node<T> newRoot = root;
                Node<T> parent;
                while (true)
                {
                    parent = newRoot;
                    if (element < newRoot.item)
                    {
                        Console.Write(" L");
                        newRoot = newRoot.left;
                        if (newRoot == null)
                        {
                            parent.left = newNode;
                            treeSize++;
                            return;
                        }
                    }
                    else
                    {
                        Console.Write(" R");
                        newRoot = newRoot.right;
                        if (newRoot == null)
                        {
                            parent.right = newNode;
                            treeSize++;
                            return;
                        }
                    }
                    Console.Write(" →");
                }
            }
        }

        public void SizeOfTree()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            Console.WriteLine("\n Size of tree is : "+treeSize);
        }

        public void Traverse(Node<T> Root)
        {
            if (Root != null)
            {
                Traverse(Root.left);
                Console.Write(Root.item + " ");
                Traverse(Root.right);
            }
        }
    }
}
