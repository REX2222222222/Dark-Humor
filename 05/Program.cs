using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Programming";
            bool startsWithPro = text.StartsWith("Pro");
            Console.WriteLine(startsWithPro); // 輸出：True
        }
    }
}
