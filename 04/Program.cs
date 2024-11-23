using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "apple";
            string copied = string.Copy(original); // 如果使用舊版 .NET，這樣可以複製字串
            Console.WriteLine(copied); // 輸出：apple
        }
    }
}
