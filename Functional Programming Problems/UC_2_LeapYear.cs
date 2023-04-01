using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_2_LeapYear
    {
        public static void LeapYear()
        {
            Console.WriteLine("Please enter a four digit number");
            int year = Convert.ToInt32(Console.ReadLine());
            int length = year.ToString().Length;
            if (length == 4)
            {
                if(year%4==0 && year%100!=0 || year % 400 == 0)
                {
                    Console.WriteLine("It is leap year");
                }
                else
                {
                    Console.WriteLine("It is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("sorry wrong input");
            }
        }
    }
}
