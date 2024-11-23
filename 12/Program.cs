using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "abracadabra";

            // 使用 IndexOf 找到字母 'a' 第一次出現的位置
            int firstIndex = text.IndexOf('a');

            Console.WriteLine(firstIndex); // 輸出：0
        }
    }
}
