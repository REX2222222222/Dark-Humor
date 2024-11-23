using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "歡迎光臨";

            // 在索引 2 的位置插入 "大家"
            string modified = original.Insert(2, "大家");

            Console.WriteLine(modified); // 輸出：歡迎大家光臨
        }
    }
}
