﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "HelloWorld";
            bool endsWithWorld = text.EndsWith("World");
            Console.WriteLine(endsWithWorld); // 輸出：True
        }
    }
}
