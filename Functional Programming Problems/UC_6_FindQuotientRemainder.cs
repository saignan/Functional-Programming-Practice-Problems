using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Functional_Programming_Problems
{
    internal class UC_6_FindQuotientRemainder
    {
        public static void FindQR()
        {
            int divisor,dividend;
            int quotient;
            int remainder;
            Console.WriteLine("Enter the dividend value:");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor value:");
            divisor = Convert.ToInt32(Console.ReadLine());
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient value is "+quotient);
            Console.WriteLine("Remainder value is "+remainder);

        }
     
    }
}
