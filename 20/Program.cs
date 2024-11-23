using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";

            // 創建一個字元陣列來存放複製的字母
            char[] charArray = new char[5];

            // 使用 CopyTo 方法複製前五個字母
            text.CopyTo(0, charArray, 0, 5);

            // 顯示字元陣列
            Console.WriteLine(new string(charArray)); // 輸出：hello
        }
    }
}
