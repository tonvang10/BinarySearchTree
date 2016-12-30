﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Binary
    {
        Node root;
        int count;

        public Binary()
        {
            root = null;
            count = 0;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void AddNumber(int number)
        {
            if (root == null)
            {
                root = new Node(number);
            }
            else
            {
                root.InsertNumber(ref root, number);
            }
            count++;
        }
        //public bool RemoveNode()
        //{
        //    return false;
        //}
        public bool Search(int numberSearched)
        {
            return root.Search(root, numberSearched);
        }
        public void Display()
        {
            if (root != null)
            {
                root.Display(root);
            }
        }
    }
}