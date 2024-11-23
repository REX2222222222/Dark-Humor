using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "Hello";

            // 使用 PadRight 將字串補足成長度 10，並以 '-' 填充
            string padded = original.PadRight(10, '-');

            Console.WriteLine($"'{padded}'"); // 輸出：'Hello-----'
        }
    }
}
