using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary<int> binary = new Binary<int>(9);
            binary.Add(10);
            binary.Add(7);
            binary.Add(4);
            binary.Add(17);
            binary.Add(16);
            binary.Add(2);
            binary.Add(21);
        }
    }                                    
}
