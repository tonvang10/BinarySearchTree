using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Binary <T> where T : IComparable
    {
        Node<T> node;
        int result;    

        public Binary(T value)
        {
            node = new Node<T>(value);
        }
        public int Count { get; set; }
        public void Add(T value)
        {
            int number;
            Node<T> newNode = new Node<T>(value);
            Node<T> root = node, parent = null;
            while (root != null)
            {
                number = root.Value.CompareTo(newNode.Value);
                if (number == 0)
                    return;
                else if (number > 0)
                {
                    parent = root;
                    root = root.LeftChild;
                }
                else if (number < 0)
                {
                    parent = root;
                    root = root.RightChild;
                }
            }
            if (parent == null)
            {
                root = newNode;
            }
            else
            {
                number = parent.Value.CompareTo(newNode.Value);
                if (number > 0)
                {
                    parent.
                        LeftChild = newNode;
                }
                else
                {
                    parent.RightChild = newNode;
                }
            }
        }
        public bool RemoveNode()
        {
            return false;
        }
        public bool SearchTree(T value)
        {
            Node<T> origin = node;
            Node<T> newNode = new Node<T>(value);
            while (origin != null)
            {
                result = origin.Value.CompareTo(newNode.Value);
                if (result == 0)
                    return true;
                else if (result > 0)
                {
                    origin = origin.LeftChild;
                }
                else if (result < 0)
                {
                    origin = origin.RightChild;
                }
            }            
            return false;
        }
    }
}