using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "apple";
            string str2 = "banana";

            // 使用 Equals 方法比較字串
            bool areEqual = str1.Equals(str2);

            Console.WriteLine(areEqual); // 輸出：False
        }
    }
}
