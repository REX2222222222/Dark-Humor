using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "apple";
            string str2 = "banana";

            // 使用 CompareTo() 比較字串
            int result = str1.CompareTo(str2);

            if (result < 0)
            {
                Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in alphabetical order.");
            }
            else if (result > 0)
            {
                Console.WriteLine($"\"{str2}\" comes before \"{str1}\" in alphabetical order.");
            }
            else
            {
                Console.WriteLine($"\"{str1}\" and \"{str2}\" are equal in alphabetical order.");
            }
        }
    }
}
