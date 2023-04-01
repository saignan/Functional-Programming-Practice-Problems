using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_7_SwapTwoNum
    {
        public static void SwapTwoNumbers()
        {
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int temp;
            Console.WriteLine("Before swap a="+a+" b="+b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Before swap a=" + a + " b=" + b);
        }
    }
}
