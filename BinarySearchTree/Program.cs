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
            Binary binary = new Binary();
            binary.AddNumber(10);
            binary.AddNumber(7);
            binary.AddNumber(4);
            binary.AddNumber(17);
            binary.AddNumber(16);
            binary.AddNumber(14);
            binary.AddNumber(2);
            binary.AddNumber(28);
            binary.AddNumber(5);
            binary.AddNumber(21);
            binary.Display();

            Console.ReadKey();
        }
    }                                    
}
