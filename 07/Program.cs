using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string part1 = "Hello";
            string part2 = " ";
            string part3 = "World";

            // 使用 Concat 方法合併字串
            string result = string.Concat(part1, part2, part3);

            Console.WriteLine(result); // 輸出：Hello World
        }
    }
}
