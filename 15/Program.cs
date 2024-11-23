using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";

            // 使用 Remove 方法移除索引 5 之後的所有字元
            string result = text.Remove(5);

            Console.WriteLine(result); // 輸出：Hello
        }
    }
}
