using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_10_LargestAmong3Num
    {
        public static void Largest()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if(a>=b && b >= c)
            {
                Console.WriteLine("greater value is "+a);
            }else if(b>=c && b >= a)
            {
                Console.WriteLine("greater value is "+b);
            }
            else
            {
                Console.WriteLine("greater value is "+c);
            }
        }
    }
}
