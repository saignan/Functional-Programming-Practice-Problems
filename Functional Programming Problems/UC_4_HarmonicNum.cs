using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_4_HarmonicNum
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Enter a value");
            float n = Convert.ToInt32(Console.ReadLine());
            float result = 0;
            if (n != 0)
            {
                for(float i = 1; i <= n; i++)
                {
                    result = result + (1 / i);
                }
            }
            Console.WriteLine(result);
        }
    }
}
