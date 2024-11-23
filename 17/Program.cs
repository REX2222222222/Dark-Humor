using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";

            // 使用 Replace 方法替換 'World' 為 'C#'
            string result = text.Replace("World", "C#");

            Console.WriteLine(result); // 輸出：Hello C#
        }
    }
}
