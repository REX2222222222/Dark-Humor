using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "cherry" };

            // 使用 Join 方法以逗號分隔字串陣列
            string result = string.Join(",", fruits);

            Console.WriteLine(result); // 輸出：apple,banana,cherry
        }
    }
}
