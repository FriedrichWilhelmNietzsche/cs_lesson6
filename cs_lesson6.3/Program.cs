using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_lesson6._3
{
    class Program  //p96 exchange data through function
    {
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        } 

        static void Main(string[] args)
        {
            int sum = SumVals(4, 5, 6, 9);
            Console.WriteLine($"{sum}"); //($"{sum}"), ("{0},sum")               
            Console.ReadKey();
        }
    }
}
