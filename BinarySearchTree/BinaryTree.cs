using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {
        public Node<T> root;
        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int element)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = element;
            if (root == null)
            { 
                root = newNode; 
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
                        Console.WriteLine(" {0} | To Left",element);
                        newRoot = newRoot.left;
                        if (newRoot == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" {0} | To Right", element);
                        newRoot = newRoot.right;
                        if (newRoot == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
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
