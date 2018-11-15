using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_lesson6._4
{
    class Program
    {
        static int DoubleValue(int val)  // static int DoubleValue(ref int val)  ref关键字指定参数
        {
            {
            val *= 2;            
            Console.WriteLine($"DoubleValue = {val}");
            }
            return val;
        }
        static void Main(string[] args)
        {
            int myValue = 5;
            Console.WriteLine($"myValue = {myValue}");
            DoubleValue(myValue);   //DoubleValue(ref myValue);  
            Console.WriteLine("{0}", myValue);
            Console.ReadKey();
        }
        
    }
}
