using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_lesson6._1
{
    class Program    //return value
    {
        static double GetVal()
        {        
            double checkVal = Convert.ToDouble(Console.ReadLine()); 
            if (checkVal < 5)                           
                return 1;
            return 2;
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            double result = GetVal();            
            Console.WriteLine("The answer is:{0}", result);
            Console.WriteLine("Press any key to exit.\n");
            Console.ReadKey();
        }
        
    }
}
