using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_8_EvenOrOdd
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a value:");
            int n= Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
