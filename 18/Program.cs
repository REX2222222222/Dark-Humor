using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "programming";

            // 使用 Substring 方法從第 3 個字元開始擷取子字串
            string result = text.Substring(2);

            Console.WriteLine(result); // 輸出：ogramming
        }
    }
}
