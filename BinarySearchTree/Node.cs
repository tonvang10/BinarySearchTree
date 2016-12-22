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
        public Node InsertNumber(Node node, int number)
        {
            if (node == null)
            {
                node = new Node(number);
            }
            else if (node.number < number)
            {
                InsertNumber(node.leftChild, number);
            }
            else if (node.number > number)
            {
                InsertNumber(node.rightChild, number);
            }
            return node;
        }
    }
}

