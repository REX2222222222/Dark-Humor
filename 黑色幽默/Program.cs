using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 黑色幽默
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "apple";
            string str2 = "banana";

            // 使用 String.Compare 方法比較字串
            int result = String.Compare(str1, str2);

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
