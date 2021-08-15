using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public int item;
        public Node<T> left;
        public Node<T> right;
    }
}
