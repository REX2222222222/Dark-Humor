using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "apple";

            // 使用 PadLeft 將字串補足成長度 10
            string padded = original.PadLeft(10);

            Console.WriteLine($"'{padded}'"); // 輸出：'     apple'（引號用來顯示空格）
        }
    }
    }
}
