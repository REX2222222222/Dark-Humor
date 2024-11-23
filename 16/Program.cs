using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love programming in C#";

            // 使用 Split 方法以空白字元分割字串
            string[] words = sentence.Split(' ');

            // 逐一輸出每個單詞
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
