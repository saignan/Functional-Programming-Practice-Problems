using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming_Problems
{
    internal class UC_9_VowelOrConsonant
    {
        public static void VowelOrConsonant()
        {
            Console.WriteLine("Enter a character");
            char a = Convert.ToChar(Console.ReadLine());
            if(a=='a' || a=='e' || a=='i'|| a=='o' || a== 'u')
                {
                Console.WriteLine(a + " is Vowel");
            }
            else
            {
                Console.WriteLine(a+" is Consonant");
            }
        }
    }
}
