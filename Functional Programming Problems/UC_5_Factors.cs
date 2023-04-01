using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_5_Factors
    {
        public static void Factors()
        {
            Console.WriteLine("Enter a value");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factors are:");
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
            }

        }
    }
}
