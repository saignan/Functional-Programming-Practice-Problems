using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Functional_Programming_Problems
{
    internal class UC_1_FlipCoin
    {
        public static void FlipCoin()
        {
            Console.WriteLine("Enter the number of times need to be Flip the coin:");
            int n= Convert.ToInt32(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int tail = 0;
            int head = 1;
            float total,p1,p2;
            for(int i = 0; i < n; i++)
            {
                Random random = new Random();
                int toss = random.Next(0, 2);
                if (toss == tail)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            total = count1 + count2;
            p1 = (count1 / total) * 100;
            p2 = (count2 / total) * 100;
            Console.WriteLine("Percentage of Tails occur "+p1);
            Console.WriteLine("Percentage of Heads occur "+p2);
        }
    }
}
