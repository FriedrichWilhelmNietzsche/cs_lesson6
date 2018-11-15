using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_lesson6._7
{
    class Program
    {
        delegate double ProcessDelegate(double paraml1, double paraml2);

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
         }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }

        static void Main(string[] args)
        {
            //get value from keyboard
            ProcessDelegate process;
            Console.WriteLine("Enter 2 numbers separated with a coma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            //definite two value
            double param1 = Convert.ToDouble(input.Substring(0,commaPos));
            double param2 = Convert.ToDouble(input.Substring  (commaPos +1, input.Length - commaPos -1));
            //choose a function
            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();
            if (input == "M")
                process = new ProcessDelegate(Multiply);
            else
                process = new ProcessDelegate(Divide);
            //print end
            Console.WriteLine($"Result: {process(param1,param2)}");
            Console.ReadKey();
                                          
        }
    }
}
