using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question1.Question1
{
    internal class Class1
    {
        static public int CountString(String v)
        {
            int kq = 0;

            return new Regex("\\s+").Split(v).Length;
        }
        static void Main()
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            Console.WriteLine("You enterd: "+s);
            Console.WriteLine("String[] you entered has: " + CountString(s));
        }
    }
}
