using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";

            // 使用 ToCharArray 將字串轉換為字元陣列
            char[] charArray = text.ToCharArray();

            // 逐一印出每個字元
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }
        }
    }
}
