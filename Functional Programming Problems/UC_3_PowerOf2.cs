using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_3_PowerOf2
    {
        public static void Power()
        {
            Console.WriteLine("Enter a value");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for(int i = 0; i < n; i++)
            {
                result *= 2;
            }
            Console.WriteLine(result);

        }
    }
}
