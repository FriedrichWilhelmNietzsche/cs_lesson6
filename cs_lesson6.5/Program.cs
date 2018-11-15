using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_lesson6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text = "";
            for (i = 0; i < 10; i++)
            {
                text = $"Line {i}:";
                Console.WriteLine($"{text}");

            }
            Console.WriteLine($"Last text output in loop:{text}");
            Console.ReadKey();
        }
    }
}
