using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "   Hello World!   ";

            // 使用 Trim 方法移除前後的空白字元
            string result = text.Trim();

            Console.WriteLine(result); // 輸出：Hello World!
        }
    }
}
