using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        int number;
        Node leftChild;
        Node rightChild;
        //Node node;

        public Node(int value)
        {
            number = value;
            leftChild = null;
            rightChild = null;
        }
        public int Number
        {
            get
            {
                return number; 
            }
        }
        public Node LeftChild
        {
            get
            {
                return leftChild;
            }
            set
            {
                leftChild = value;
            }
        }
        public Node RightChild
        {
            get
            {
                return rightChild;
            }
            set
            {
                rightChild = value;
            }
        }
        public void InsertNumber(ref Node node, int number)
        {
            if (node == null)
            {
                node = new Node(number);
            }
            else if (node.number < number)
            {
                InsertNumber(ref node.leftChild, number);
            }
            else if (node.number > number)
            {
                InsertNumber(ref node.rightChild, number);
            }
        }
        public bool Search(Node node, int numberSearched)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.number < numberSearched)
            {
                return Search(node.leftChild, numberSearched);
            }
            else if (node.number > numberSearched)
            {
                return Search(node.rightChild, numberSearched);
            }
            if (node.number == numberSearched)
            {
                return true;
            }
            return false;
        }
        public void Display(Node node)
        {
            if (node == null)
                return;
            Display(node.RightChild);
            Console.WriteLine("{0}", node.Number);
            Display(node.LeftChild);
        }
    }
}

