using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_lesson6._2
{
    class Program // compare numbers size in array
    {
        static int MaxValue()
        {
           
            int[] intArray = new int[10]; //definit an array with 10 numbers
            int maxVal = intArray[0];  //the max is the first number
            for (int i = 1; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32( Console.ReadLine()); //get numbers from keyboard
                if (intArray[i] > maxVal)            //compare
                    maxVal = intArray[i];
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ten numbers:");
            int maxVal = MaxValue();  //run function
            Console.WriteLine("The max value in my array is:{0}",maxVal);
            Console.ReadKey();
        }
    }
}
